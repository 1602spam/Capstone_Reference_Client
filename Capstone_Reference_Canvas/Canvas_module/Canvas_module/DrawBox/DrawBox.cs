using Canvas_module.Controller;
using Canvas_module.DrawObjects;
using Canvas_module.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas_module.DrawBox
{
	public partial class DrawBox : UserControl, IObserver
	{
		#region 전역 변수

		//속성 설정 폼
		private PropertiesView properies;

		//선택된 객체의 사이즈를 변경할 때 사용
		private DrawObject resizedObject;

		//사이즈가 변경 될 객체의 핸들 번호를 가져옴.
		private int resizedObjectHandle;

		//마우스 시작 위치
		private Point startPoint = new Point(0, 0);

		//마우스 마지막 위치
		private Point lastPoint = new Point(0, 0);

		//이전 endPoint 를 저장
		private Point oldPoint;

		//DrawObject를 그릴 수 있는 DrawBox 사이즈를 수정 할 수 있는지 여부를 저장하는 변수
		private bool allowResize = false;

        /// <summary>
        /// Pencil 을 그릴 때 마지막으로 그려진 Location.X 를 저장한다.
        /// </summary>
        private int lastX;

        /// <summary>
        /// Pencil 을 그릴 때 마지막으로 그려진 Location.Y 를 저장한다.
        /// </summary>
        private int lastY;

        /// <summary>
        /// Pencil 도구로 그릴 때 사용되는 PencilObject 변수
        /// </summary>
        private PencilObject newPencil;

        /// <summary>
        /// Pencil 도구로 그릴 때 연결 점 사이의 최소 거리를 지정하는 상수
        /// </summary>
        private const int MinDistance = 15 * 15;
        #endregion

        #region 생성자
        public DrawBox()
		{
			InitializeComponent();

			#region Paint 이벤트와 관련해서 유용한 sytle을 적용
			//참고 링크 : https://learn.microsoft.com/ko-kr/dotnet/api/system.windows.forms.controlstyles?view=windowsdesktop-7.0
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.UpdateStyles();
			this.DoubleBuffered = true;
			#endregion

			MainController.Instance.Subscribe(this);

		}

		#endregion


		#region 옵저버 패턴

		/// <summary>
		/// 수신된 ObserverAction에 따라 처리
		/// </summary>
		public void OnNext(ObserverAction action)
		{
			switch (action)
			{
				case ObserverAction.Invalidate: this.Invalidate(false); return;
				case ObserverAction.FileLoad: this.Invalidate(false); return;
				case ObserverAction.New: this.Invalidate(false); return;
			}
		}

		/// <summary>
		/// 수신된 ObserverClass 의 Action 에 따라서 처리한다.
		/// </summary>
		public void OnNext(ObserverClass obserber)
		{
			switch (obserber.Action)
			{
				case ObserverAction.Invalidate: this.Invalidate(false); return;
				case ObserverAction.FileLoad: this.Invalidate(false); return;
				case ObserverAction.New: this.Invalidate(false); return;

			}
		}


		#endregion

		#region DrawBox 크기 조절 이벤트

		#endregion

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			allowResize = true;
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (allowResize)
			{
				this.Height = pictureBox1.Top + e.Y;
				this.Width = pictureBox1.Left + e.X;
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			allowResize = false;
		}

		#region 내부함수
		/// <summary>
		/// DraBox에 그려진 모든 DrawObject의 선택을 해제함.
		/// </summary>
		private void UnSelectAll()
		{
			foreach (DrawObject o in MainController.Instance.GraphicModel.GrapList)
			{
				o.Selected = false;
			}
		}

        private DrawObject AddNewDrawObject(DrawObjectType type, Point location)
        {
            switch (type)
            {
                case DrawObjectType.Rectangle: return new RectangleObject(location.X, location.Y, 1, 1);
                case DrawObjectType.Ellipse: return new EllipseObject(location.X, location.Y, 1, 1);
                case DrawObjectType.Line: return new LineObject(location.X, location.Y, location.X + 1, location.Y + 1);
                case DrawObjectType.Pencil:
                    lastX = location.X;
                    lastY = location.Y;
                    return newPencil = new PencilObject(location.X, location.Y, location.X + 1, location.Y + 1);
            }


            return new RectangleObject(location.X, location.Y, 1, 1);
        }




        #endregion

        #region 그리기 관련 이벤트
        /// <summary>
        /// 새롭게 객체를 그리거나, 그려진 객체를 선택한다.
        /// </summary>
        private void DrawBox_MouseDown(object sender, MouseEventArgs e)
        {
            //마우스가 왼쪽 클릭이고, 그리기 도구에서 선택하기를 선택했을 경우
            if (e.Button == MouseButtons.Left && MainController.Instance.DrawObjectType == DrawObjectType.Select)
            {
                //현재 DrawBox 상태를 아무것도 지정하지 않는다.
                MainController.Instance.SelectMode = SelectMode.None;

                foreach (DrawObject ob in MainController.Instance.GraphicModel.GrapList)
                {
                    int handleNumber = ob.HitTest(e.Location); //현재 클릭된 위치의 handleNumber 를 반환한다.

                    //handleNumber 가 0보다 크다면 DrawObject 가 선택 된 것이다.
                    if (handleNumber > 0)
                    {
                        //현재 DrawBox 상태를 사이즈 변경 모드로 변경한다.
                        MainController.Instance.SelectMode = SelectMode.Size;

                        //사이즈 변경을 할 수 있도록 준비한다.
                        resizedObject = ob;
                        resizedObjectHandle = handleNumber;

                        //DrawBox 그려진 모든 DrawObject 의 선택을 해제한다.
                        UnSelectAll();

                        //현재 클릭된 DrawObejct 를 선택한다.
                        ob.Selected = true;

                        break;
                    }
                }


                if (MainController.Instance.SelectMode == SelectMode.None)
                {
                    foreach (DrawObject o in MainController.Instance.GraphicModel.GrapList)
                    {
                        if (o.HitTest(e.Location) == 0)
                        {
                            //Ctrl 키가 눌러지지 않은 상태에서 DrawObject 를 선택하면 모든 DrawObjec의 선택을 해제하고 현재 DrawObject 를 선택한다.
                            if ((Control.ModifierKeys & Keys.Control) == 0 && !o.Selected)
                            {
                                UnSelectAll();
                                o.Selected = true;
                            }
                            else if ((Control.ModifierKeys & Keys.Control) != 0 && o.Selected)
                            {
                                //이미 선택된 DrawObject 라면 선택을 해제한다.
                                o.Selected = false;
                            }
                            else
                            {
                                //Ctrl 키가 눌러진 상태라면 기존 선택을 해제하지 않고 추가로 현재 DrawObject 를 선택한다.
                                o.Selected = true;
                            }

                            //마우스 커서를 바꿔준다.
                            this.Cursor = Cursors.SizeAll;

                            //DrawBox 상태를 이동으로 변경한다.
                            MainController.Instance.SelectMode = SelectMode.Move;

                            break;
                        }
                    }
                }


                //DrawBox 의 상태가 아무것도 지정되지 않고 키보드를 누른 상태가 아니라면 DrawBox 에 선택된 모든 객체를 해제한다.
                if (MainController.Instance.SelectMode == SelectMode.None)
                {
                    if ((Control.ModifierKeys & Keys.Control) == 0)
                        UnSelectAll();

                    //DrawBox 의 상태를 영역으로 선택하기로 변경한다.
                    MainController.Instance.SelectMode = SelectMode.NetSelection;
                }

                //현재의 마우스 위치를 저장한다.
                lastPoint = e.Location;
                startPoint = e.Location;

                //마우스를 캡쳐한다.
                this.Capture = true;

                //DrawBox의 상태가 영역으로 선택하기 일떄, 영역 그리기를 시작한다.
                if (MainController.Instance.SelectMode == SelectMode.NetSelection)
                {
                    ControlPaint.DrawReversibleFrame(this.RectangleToScreen(RectangleObject.GetNormalizedRectangle(startPoint, lastPoint)), Color.Black, FrameStyle.Dashed);
                }
            }

            //마우스의 왼쪽을 클릭하고, DrawObjectType 이 선택하기가 아니라면 선택 DrawObject 를 그리기 시작한다.
            else if (e.Button == MouseButtons.Left && !(MainController.Instance.DrawObjectType == DrawObjectType.Select))
            {
                //모든 DrawObject 선택 해제
                UnSelectAll();

                //현재 상태를 실행취소(Undo) & 다시실행(Redo) Command 에 등록한다.
                MainController.Instance.Command.AddCommand(MainController.Instance.GraphicModel.GrapList);

                //새로운 DrawObject 를 GrapList 에 등록한다.
                MainController.Instance.GraphicModel.GrapList.Insert(0, AddNewDrawObject(MainController.Instance.DrawObjectType, e.Location));


                //마우스를 캡쳐한다.
                this.Capture = true;

            }

            //마우스 우클릭시 팝업 메뉴를 보여준다.
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                SetToolStripMenu();

                contextMenuStrip1.Show(MousePosition);

                return;
            }

        }
        private void DrawBox_MouseMove(object sender, MouseEventArgs e)
        {
            oldPoint = lastPoint;

            //마우스 왼쪽 클릭이고, DrawObjectType 이 선택하기가 아닐 때
            if (e.Button == MouseButtons.Left && MainController.Instance.DrawObjectType != DrawObjectType.Select)
            {
                //Pencil 그리기 일때
                if (MainController.Instance.DrawObjectType == DrawObjectType.Pencil && newPencil != null)
                {
                    Point point = new Point(e.X, e.Y);
                    int distance = (e.X - lastX) * (e.X - lastX) + (e.Y - lastY) * (e.Y - lastY);

                    //연결점 사이의 거리가 최소 거리보다 적을 때
                    if (distance < MinDistance)
                    {
                        //Pencil의 라인을 연장해서 그린다
                        newPencil.MoveHandleTo(point, newPencil.HandleCount);
                    }
                    else //연결점 사이의 거리가 최소 거리보다 멀 때
                    {
                        //새로운 연결점 추가
                        newPencil.AddPoint(e.Location);
                        lastX = e.X;
                        lastY = e.Y;
                    }
                }
                else
                {
                    //Pencil 이 DrawObject 를 그려준다.
                    MainController.Instance.GraphicModel.GrapList[0].MoveHandleTo(e.Location, 5);
                }

                //DrawBox 의 Paint 이벤트를 호출해서 새롭게 그린다.
                this.Invalidate(false);
                return;
            }

            //마우스 왼쪽 클릭이고, DrawObjectType 이 선택하기 일때
            else if (e.Button == MouseButtons.Left && MainController.Instance.DrawObjectType == DrawObjectType.Select)
            {
                //마우스의 현재 위치에서 마지막 위치를 뺀 값을 저장한다.
                int distanceX = e.X - lastPoint.X;
                int distanceY = e.Y - lastPoint.Y;

                //마우스의 현재 위치를 마지막 값으로 저장한다.
                lastPoint = e.Location;

                //DrawBox 의 현재 상태가 사이즈 변경 모드일때
                if (MainController.Instance.SelectMode == SelectMode.Size)
                {
                    if (resizedObject != null)
                    {
                        //DrawObject 의 사이즈를 변경한다.
                        resizedObject.MoveHandleTo(e.Location, resizedObjectHandle);

                        //DrawBox의 Paint 이벤트를 호출한다.
                        this.Invalidate(false);

                        return;
                    }
                }

                //DrawBox 의 현재 상태가 이동 모드일때
                if (MainController.Instance.SelectMode == SelectMode.Move)
                {
                    //선택된 모든 DrawObject의 위치를 이동한다.
                    foreach (DrawObject o in MainController.Instance.GraphicModel.GrapList)
                    {
                        if (o.Selected)
                        {
                            o.Move(distanceX, distanceY);
                        }
                    }

                    //마우스 커서를 변경한다.
                    this.Cursor = Cursors.SizeAll;

                    //DrawBox 의 Paint 이벤트를 호출한다.
                    this.Invalidate(false);

                    return;
                }

                //DrawBox 의 현재 상태가 영역으로 선택 모드일때
                if (MainController.Instance.SelectMode == SelectMode.NetSelection)
                {
                    //마우스로 이동된 만큼 영역을 그려준다.
                    ControlPaint.DrawReversibleFrame(this.RectangleToScreen(RectangleObject.GetNormalizedRectangle(startPoint, oldPoint)), Color.Black, FrameStyle.Dashed);
                    ControlPaint.DrawReversibleFrame(this.RectangleToScreen(RectangleObject.GetNormalizedRectangle(startPoint, e.Location)), Color.Black, FrameStyle.Dashed);

                    return;
                }
            }

            //마우스가 클릭이 된 것이 없고, DrawObjectType 이 선택하기 일때
            else if (e.Button == System.Windows.Forms.MouseButtons.None && MainController.Instance.DrawObjectType == DrawObjectType.Select)
            {
                //핸들의 위치에 맞게 마우스 커서를 변경해준다.
                foreach (DrawObject ob in MainController.Instance.GraphicModel.GrapList)
                {
                    Cursor = ob.GetHandleCursor(ob.HitTest(e.Location));
                    return;
                }
            }


        }

        private void DrawBox_MouseUp(object sender, MouseEventArgs e)
        {
            //마우스 왼쪽 버튼이 클릭된 상태였고, DrawObjectType 이 선택하기가 아닐 때,
            if (e.Button == MouseButtons.Left && !(MainController.Instance.DrawObjectType == DrawObjectType.Select))
            {
                //DrawBox 의 상태를 아무것도 지정하지 않는다.
                MainController.Instance.SelectMode = SelectMode.None;

                //새롭게 추가되어 그려진 DrawObject 를 최종 상태로 설정한다.
                MainController.Instance.GraphicModel.GrapList[0].Normalize();

                //Pencil 변수를 null 로 초기화 한다.
                newPencil = null;

                MainController.Instance.Notify(ObserverAction.Select);
            }
            else
            {
                ////DrawBox 의 상태가 영역으로 선택하기 일 때
                if (MainController.Instance.SelectMode == SelectMode.NetSelection)
                {
                    ControlPaint.DrawReversibleFrame(this.RectangleToScreen(RectangleObject.GetNormalizedRectangle(startPoint, lastPoint)), Color.Black, FrameStyle.Dashed);

                    //모든 DrawObject 의 선택을 해제한다.
                    UnSelectAll();

                    //마우스의 처음과 마지막 위치 만큼의 Rectangle 을 생성한다.
                    Rectangle rec = RectangleObject.GetNormalizedRectangle(startPoint, lastPoint);

                    //rec 의 영역에 DrawObject 가 포함된다면 선택된걸로 설정한다.
                    foreach (DrawObject o in MainController.Instance.GraphicModel.GrapList)
                    {
                        if (o.IntersectsWith(rec))
                            o.Selected = true;
                    }

                    //DrawBox 의 상태를 아무것도 지정하지 않는다.
                    MainController.Instance.SelectMode = SelectMode.None;
                }

                //DrawObjec 의 사이즈 변경 변수가 Null 이 아니라면 변경된 된 크기만큼 최종적으로 설정해준다.
                if (resizedObject != null)
                {
                    resizedObject.Normalize();
                    resizedObject = null;
                }

                //DrawBox 의 Paint 이벤트를 호출한다.
                this.Invalidate(false);
            }

            //마우스 캡쳐를 해제한다.
            this.Capture = false;
        }

        private void DrawBox_Paint_1(object sender, PaintEventArgs e)
        {
            //그려진 DrawObject가 하나 이상 일때
            if (MainController.Instance.GraphicModel.GrapList.Count > 0)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
                {
                    //e.Graphics.FillRectangle(brush, this.ClientRectangle);

                    foreach (DrawObject ob in MainController.Instance.GraphicModel.GrapList)
                    {
                        //DrawObject 를 그려준다.
                        ob.Draw(e.Graphics);

                        //DrawObject 가 선택되었다면 선택된 DrawObject 를 표시하기 위한 Pointer를 그려준다
                        if (ob.Selected == true)
                        {
                            ob.DrawPointer(e.Graphics);
                        }
                    }
                }
            }
        }

        #endregion

        #region 메뉴 버튼 설정
        private void SetToolStripMenu()
        {
			if (MainController.Instance.Command.CanUndo)
			{
				UndotoolStripMenuItem.Enabled = true;
			}
			else
			{
				UndotoolStripMenuItem.Enabled = false;
			}
			if (MainController.Instance.Command.CanRedo)
			{
				RedotoolStripMenuItem.Enabled = true;
			}
			else
			{
				RedotoolStripMenuItem.Enabled = false;
			}
			// 선택된 DrawObject가 하나 일때만 설정 가능
			if(MainController.Instance.GraphicModel.SelectedCount == 1)
			{
				PropertiestoolStripMenuItem.Enabled = true;
			}
			else
			{
				PropertiestoolStripMenuItem.Enabled = false;

			}
        }
        #endregion

        #region 팝업 메뉴

        #endregion

        private void SelectAlltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DrawObjects.DrawObject item in MainController.Instance.GraphicModel.GrapList)
            {
                item.Selected = true;
            }

            //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
            MainController.Instance.Notify(ObserverAction.Invalidate);
        }

        private void UnselectAlltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DrawObjects.DrawObject item in MainController.Instance.GraphicModel.GrapList)
            {
                item.Selected = false;
            }

            //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
            MainController.Instance.Notify(ObserverAction.Invalidate);
        }

        private void DeletetoolStripMenuItem_Click(object sender, EventArgs e)
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

        private void DeleteAlltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainController.Instance.GraphicModel.GrapList.Count > 0)
            {
                MainController.Instance.Command.AddCommand(MainController.Instance.GraphicModel.GrapList);
                MainController.Instance.GraphicModel.GrapList.Clear();

                //DrawBox 가 새롭게 그리게끔 Observer에게 알린다.
                MainController.Instance.Notify(ObserverAction.Invalidate);
            }
        }

        private void PropertiestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DrawObject obj in MainController.Instance.GraphicModel.GrapList)
            {
                if (obj.Selected)
                {
                    properies = new PropertiesView(obj.Color, obj.BackColor);

                    if (properies.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        obj.Color = properies.Color;
                        obj.BackColor = properies.BackGroundColor;
                        obj.PenWidth = properies.PenWidth;

                        MainController.Instance.Notify(ObserverAction.Invalidate);
                    }

                    properies.Dispose();

                    break;
                }
            }
        }

        private void UndotoolStripMenuItem_Click(object sender, EventArgs e)
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

        private void RedotoolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}

