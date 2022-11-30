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
		private PropertiesView? properies;

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
        //실행 취소
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainController.Instance.Command.CanUndo)
            {
                if (MainController.Instance.Command.Undo())
                {
                    //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
                    MainController.Instance.Notify(ObserverAction.Invalidate);

                    //Command 의 상태가 갱신되게끔 Observer에게 알린다.
                    MainController.Instance.Notify(ObserverAction.Command);
                }
            }
        }

        private void RedoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MainController.Instance.Command.CanRedo)
            {
                if (MainController.Instance.Command.Redo())
                {
                    //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
                    MainController.Instance.Notify(ObserverAction.Invalidate);

                    //Command 의 상태가 갱신되게끔 Observer에게 알린다.
                    MainController.Instance.Notify(ObserverAction.Command);
                }
            }
        }


        #endregion

        #region 도구메뉴
        private void pointertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///옵저버에게 선택하기가 선택되었음을 알린다.
            MainController.Instance.Notify(ObserverAction.Select);
        }

        private void rectangletoolStripMenuItem_Click(object sender, EventArgs e)
        {

            ///옵저버에게 사각형 그리기가 선택되었음을 알린다.
            MainController.Instance.Notify(ObserverAction.Rectangle);
        
        }

        private void EllipsetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///옵저버에게 원 그리기가 선택되었음을 알린다.
            MainController.Instance.Notify(ObserverAction.Ellipse);
        }

        private void linetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///옵저버에게 라인 그리기가 선택되었음을 알린다.
            MainController.Instance.Notify(ObserverAction.Line);
        }

        private void penciltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///옵저버에게 연필이 선택되었음을 알린다.
            MainController.Instance.Notify(ObserverAction.Pencil);
        }

        #endregion

        #region 도움말
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DrawTool 을 이용해 주셔서 감사합니다.");
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
				PropertiesToolStripMenuItem.Enabled = true;
			}
			else
			{
				PropertiesToolStripMenuItem.Enabled = false;
			}
			
        }

        #endregion

        /// <summary>
        ///  속성 설정하기 
        /// </summary>
        /// 
        
        private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DrawObjects.DrawObject obj in MainController.Instance.GraphicModel.GrapList)
            {
                if (obj.Selected)
                {
                    properies = new PropertiesView(obj.Color, obj.BackColor);

                    if (properies.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        obj.Color = properies.Color;
                        obj.BackColor = properies.BackGroundColor;
                        obj.PenWidth = properies.PenWidth;

                        Console.WriteLine(obj.Color.ToString(), obj.BackColor.ToArgb(), obj.PenWidth);
                        MainController.Instance.Notify(ObserverAction.Invalidate);
                    }

                    properies.Dispose();

                    break;
                }
            }
        }

        #endregion

        #region 새로 만들기 & 저장하기 & 불러오기

        /// <summary>
        /// 새로 만들기 
        /// 새로 만들기 전에 이전의 작업 내용을 저장 할 것인지 물어보고 진행한다.
        /// </summary>
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
        /// Model.Grapic 클래스를 바이너리로 직렬화해서 파일로 저장한다.
        /// 파일 확장자는 DTF 이다. (예 : ex.DTF 로 저장된다.)
        /// </summary>
        private void FileSave()
        {
            //파일 저장 대화창을 이용해서 저장할 위치와 파일명을 입력한다.
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
                    BinaryFormatter bf = new BinaryFormatter();

                    //MainController.Instance.GraphicModel 을 바이너리 직렬화한 후 파일로 저장한다.
                    bf.Serialize(fs, MainController.Instance.GraphicModel);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }

        /// <summary>
        /// 불러오기
        /// 파일을 역직렬화 해서 Model.Grapic 클래스 형으로 바꾸어 준다.
        /// </summary>
        private void FileLoad()
        {
            //파일 불러오기 대화창을 이용해서 불러올 파일의 위치와 파일명을 입력한다.
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    FileStream fs = null;
                    try
                    {

                        fs = new FileStream(openFileDialog1.FileName, FileMode.Open);

                        BinaryFormatter bf = new BinaryFormatter();

                        //파일을 Model.Graphic 클래스로 역직렬화 한다.
                        Model.Graphic tmpItem = bf.Deserialize(fs) as Model.Graphic;

                        fs.Close();

                        if (tmpItem != null)
                        {
                            //기존에 작성된 내용은 삭제한다.
                            MainController.Instance.GraphicModel.GrapList.Clear();

                            //역직렬화 한 tmpItem 을 MainController.Instance.GraphicModel 에 넣어 준다.
                            MainController.Instance.GraphicModel = tmpItem;

                            //실행 취소와 다시 실행 항목을 초기화 한다.
                            MainController.Instance.Command.Clear();

                            //실행 취솨와 다시 실행 버튼의 상태를 설정한다.
                            SetToolStripMenu();

                            //불러오기가 완료 되었음을 옵저버에게 알린다.
                            MainController.Instance.Notify(ObserverAction.FileLoad);

                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
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
			if (MessageBox.Show("작성 중인 내용을 저장 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				FileSave();
			}
		}














        #endregion

        
    }
}
