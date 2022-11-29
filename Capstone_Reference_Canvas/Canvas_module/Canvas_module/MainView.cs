using Canvas_module.Controller;
using Canvas_module.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Canvas_module
{
	public partial class MainView : Form, IObserver
	{

		#region 전역변수
		private PropertiesView properties;

        #endregion

        #region 생성자
        public MainView()
		{
			InitializeComponent();

			SetToolStripMenu();

			//옵저버 구독
			MainController.Instance.Subscribe(this);
		}


        #endregion
        private void MainView_Load(object sender, EventArgs e)
        {

        }
        #region 메뉴 클릭 이벤트
			#region 파일 메뉴
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLoad();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileSave();
        }

        private void save_pngtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileSave_Png();
        }

       


        #endregion

        #region 편집 메뉴
        // 전체 선택하기 : Drawbox 에 그려진 모든 DrawObject를 선택
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DrawObjects.DrawObject item in MainController.Instance.GraphicModel.GrapList)
            {
                item.Selected = true;
            }

            //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
            MainController.Instance.Notify(ObserverAction.Invalidate);
        }

		//전체 선택하기
        private void UnselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DrawObjects.DrawObject item in MainController.Instance.GraphicModel.GrapList)
            {
                item.Selected = false;
            }

            //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
            MainController.Instance.Notify(ObserverAction.Invalidate);
        }

		//삭제하기
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MainController.Instance.GraphicModel.GrapList.Count; i++)
            {
                if (MainController.Instance.GraphicModel.GrapList[i].Selected)
                {
                    MainController.Instance.Command.AddCommand(MainController.Instance.GraphicModel.GrapList);
                    MainController.Instance.GraphicModel.GrapList.RemoveAt(i);

                    //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
                    MainController.Instance.Notify(ObserverAction.Invalidate);
                }
            }
        }

		// 전체 삭제하기
        private void DeleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainController.Instance.GraphicModel.GrapList.Count > 0)
            {
                MainController.Instance.Command.AddCommand(MainController.Instance.GraphicModel.GrapList);
                MainController.Instance.GraphicModel.GrapList.Clear();

                //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
                MainController.Instance.Notify(ObserverAction.Invalidate);
            }
        }
        #endregion

        #region 옵저버 패턴
        /// <summary>
        /// 수신된 ObservserAction에 따라서 처리 한다.
        /// </summary>
        public void OnNext(ObserverAction action)
		{
			switch (action)
			{
				case ObserverAction.Command: SetToolStripMenu(); return;
                case ObserverAction.Invalidate: SetToolStripMenu(); return;
                case ObserverAction.Select: SetToolStripMenu(); return;
            }
		}

        public void OnNext(ObserverClass obserber)
        {
            if(obserber.Name == ObserverName.ToolBar)
			{
				switch (obserber.Action)
				{
					case ObserverAction.FileLoad: FileLoad(); return;
					case ObserverAction.FileSave: FileSave(); return;
					case ObserverAction.New: New(); return;
				}
			}
        }


		#endregion

		#region 메뉴 버튼 설정
		private void SetToolStripMenu()
        {
			if (MainController.Instance.Command.CanUndo) 
			{
                UndoToolStripMenuItem.Enabled = true;
            }
			else
			{
				UndoToolStripMenuItem.Enabled = false;
			}

			if (MainController.Instance.Command.CanRedo)
			{
				RedoToolStripMenuItem1.Enabled = true;
			}
			else
			{
				RedoToolStripMenuItem1.Enabled = false;
			}

			//선택된 DrawObject가 하나일 때만 실행 가능하게 한다.
			if(MainController.Instance.GraphicModel.SelectedCount == 1)
			{
				PropertiesStripMenuItem1.Enabled = true;
			}
			else
			{
				PropertiesStripMenuItem1.Enabled = false;
			}
			
        }

        #endregion

        /// <summary>
        ///  속성 설정하기 
        /// </summary>

        #endregion

        #region file new, save, open 


        private void New()
        {
            if (MessageBox.Show("새로운 그래프를 작성합니다. 작성 중인 내용은 모두 삭제됩니다.", "확인", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (MessageBox.Show("작성 중인 내용을 저장 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    FileSave();
                }

                //현재까지 작업된 내용을 삭제한다.
                MainController.Instance.GraphicModel.GrapList.Clear();

                //실행취소와 다시실행에 등록된 내용을 초기화 한다.
                MainController.Instance.Command.Clear();

                //새로운 만들기가 호출 되었음을 옵저버에게 알린다.
                MainController.Instance.Notify(ObserverAction.New);
            }
        }


        /// <summary>
        /// 저장하기
        /// </summary>
        private void FileSave()
        {
            //파일 저장 대화창, 저장할 위치와 파일명 입력.
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				FileStream? fs = null;

				try
				{
					fs = new FileStream(saveFileDialog1.FileName, FileMode.Open);

					BinaryFormatter bf = new BinaryFormatter();

                    
					//파일을 Model.Graphic 클래스로 역직렬화한다.
					Model.Graphic tmpItem = bf.Deserialize(fs) as Model.Graphic;
                    Console.WriteLine("역직렬화 성공");
                    //MainController, Instance, GraphicModel 을 바이너리 직렬화 한 후 파일로 저장한다.
                    bf.Serialize(fs, MainController.Instance.GraphicModel);
                    Console.WriteLine("저장완료");
					fs.Close();
	
				}
				catch (Exception e)
				{
                    Console.WriteLine(e);
				}
			}
        }

        private void FileLoad()
        {
			openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (File.Exists(openFileDialog1.FileName))
				{
					FileStream? fs = null;

					try
					{
						fs = new FileStream(openFileDialog1.FileName, FileMode.Open);

						BinaryFormatter? bf = new BinaryFormatter();

						// 파일을 Model.Graphic 클래스로 역직렬화
						Model.Graphic tmpItem = bf.Deserialize(fs) as Model.Graphic;

						fs.Close();

						if(tmpItem != null)
						{
							MainController.Instance.GraphicModel.GrapList.Clear(); //기존 작성 내용 삭제
							MainController.Instance.GraphicModel = tmpItem; //tmpItem을 GraphicModel 에 넣어줌.
							MainController.Instance.Command.Clear(); //실행 취소 및 다시 실행 항목 초기화
							SetToolStripMenu(); //실행 취소와 다시 실행 버튼의 상태를 설정
							MainController.Instance.Notify(ObserverAction.FileLoad); //불러오기가 완료됨-> 옵저버에게 알림.

						}
					}
					catch (Exception e)
					{

                        Console.WriteLine(e);
					}
				}
			}
        }

        private void FileSave_Png()
        {


        }
        #endregion

        #region 폼이 닫힐 때

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("프로그램을 종료하시겠습니까?", "확인", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
			{
				e.Cancel = true;
				return;
			}
			if (MessageBox.Show("프로그램을 종료하시겠습니까?", "확인", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				FileSave();
				return;
			}
		}





        #endregion

        private void drawBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
