 using Canvas_module.Controller;
using Canvas_module.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            Capture_Load();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileSave_Png();
        }

        private void save_pngtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileSave_Png();
        }

        private void CapturetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capture_Load();
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

        private void TextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //옵저버에게 텍스트박스가 선택되었음을 알린다.
            MainController.Instance.Notify(ObserverAction.TextBox);
        }

        #endregion

        #region 도움말
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Draw_Canvas를 이용해 주셔서 감사합니다.");
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
					case ObserverAction.FileLoad: Capture_Load(); return;
					case ObserverAction.FileSave: FileSave_Png(); return;
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

        #region 새로 만들기 & 저장하기  & 불러오기

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
                    FileSave_Png();
                }

                //현재까지 작업된 내용을 삭제한다.
                MainController.Instance.GraphicModel.GrapList.Clear();

                //실행취소와 다시실행에 등록된 내용을 초기화 한다.
                MainController.Instance.Command.Clear();

                //새로운 만들기가 호출 되었음을 옵저버에게 알린다.
                MainController.Instance.Notify(ObserverAction.New);

            }
        }

        private void FileSave_Png()
        {
            //ScreenShot(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height, 0, 0); //화면 전체캡쳐
            ScreenShot(this.drawBox1.Width, this.drawBox1.Height, this.Location.X + this.drawBox1.Location.X, this.Location.Y + this.drawBox1.Location.Y);

        }

        private void ScreenShot(int width, int height, int x, int y)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.CopyFromScreen(x, y, 0, 0, bitmap.Size);

            //현재 프로젝트 위치에 저장됩니다.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "이미지 파일(.jpg) | *.jpg | 모든 파일(*.*) | *.*";
            saveFileDialog.Title = "파일 저장하기";
            saveFileDialog.FileName = "";
            string path = Environment.CurrentDirectory;
            string fileName = "image11.png";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(Path.Combine(path + fileName));
                bitmap.Save(Path.Combine(path, fileName), ImageFormat.Png);
            }
          
        }

        private void Capture_Load()
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "이미지 파일(.jpg)|*.jpg|모든 파일(*.*)|*.*";
            openFileDialog.Title = "캡쳐화면 가져오기";
            openFileDialog.FileName = "";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            
            
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    Stream imageStreamSource = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    
                    //openFIleDialog를 열어서 일치하는 filename 값을 img 속성에 넣음
                    drawBox1.BackgroundImage = new Bitmap(openFileDialog.FileName);
                    this.ClientSize = drawBox1.BackgroundImage.Size;
   
                }
            }

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
				FileSave_Png();
			}
		}



        #endregion

        
    }
}
