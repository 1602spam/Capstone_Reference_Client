using Canvas_module.Controller;
using Canvas_module.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas_module.ToolBar
{
    public partial class ToolBar : UserControl, IObserver
    {

        #region 전역변수
        /// <summary>
        /// 그리기 도구 버튼 관리 리스트
        /// </summary>
        private List<ToolStripButton> drawButtonList = new List<ToolStripButton>();

        /// <summary>
        /// Toolbar에서 사용할 ObserverClass
        /// </summary>
        private ObserverClass observer = new ObserverClass("ToolBar");

        #endregion

        #region 생성자
        public ToolBar()
        {
            InitializeComponent();
            #region 툴바의 버튼 중 그리기 도구 관련된 버튼들을 drawButtonList에 추가한다.

            drawButtonList.Add(toolStripButtonEllipse);
            drawButtonList.Add(toolStripButtonLine);
            drawButtonList.Add(toolStripButtonSelect);
            drawButtonList.Add(toolStripButtonPencil);
            drawButtonList.Add(toolStripButtonRectangle);

            #endregion

            //선택하기 버튼으로 설정
            SetToolBarButtonState("Select");

            //옵저버에 ToolBar 등록
            MainController.Instance.Subscribe(this);
        }


        #endregion

        #region 옵저버 패턴

        /// <summary>
        /// 수신된 ObserverAction 에 따라서 처리 한다.
        /// </summary>
        public void OnNext(ObserverAction action)
        {
            switch (action)
            {
                case ObserverAction.Command: SetUndoRedoButton(); return;
                case ObserverAction.Invalidate: SetToolBarButtonState("Select"); return;
                case ObserverAction.Ellipse: SetToolBarButtonState("Ellipse"); return;
                case ObserverAction.Line: SetToolBarButtonState("Line"); return;
                case ObserverAction.Pencil: SetToolBarButtonState("Pencil"); return;
                case ObserverAction.Rectangle: SetToolBarButtonState("Rectangle"); return;
                case ObserverAction.Select: SetToolBarButtonState("Select"); return;
                case ObserverAction.FileLoad: SetToolBarButtonState("Select"); SetUndoRedoButton(); return;
                case ObserverAction.New: SetToolBarButtonState("Select"); SetUndoRedoButton(); return;
            }
        }

        /// <summary>
        /// 수신된 ObserverClass 와 Action 에 따라서 처리한다.
        /// </summary>
        public void OnNext(ObserverClass observer)
        {

        }

        #endregion

        #region 내부 함수

        public void SetUndoRedoButton()
        {
            if (MainController.Instance.Command.CanUndo)
            {
                toolStripButtonUndo.Enabled = true;
            }
            else toolStripButtonUndo.Enabled = false;

            if(MainController.Instance.Command.CanRedo)
            {
                toolStripButtonRedo.Enabled = true;
            }
            else toolStripButtonRedo.Enabled = false;
        }

        /// <summary>
        /// 그리기 도구 선택 시, 선택된 버튼과 관련된 설정
        /// </summary>
        /// <param name="buttonName"> 버튼의 이름을 인수로 받음</param>
        private void SetToolBarButtonState(string buttonName)
        {
            Console.WriteLine(buttonName);

            foreach(ToolStripButton item in drawButtonList)
            {
                Console.WriteLine(item.Text);

                if(item.Text == buttonName)
                {
                    Console.WriteLine("힘들어요");
                    item.Enabled = false;
                    item.BackColor = Color.DarkGray;

                    //현재 선택된 그리기 도구를 Maincontroller 에 넣어준다.
                    MainController.Instance.DrawObjectType = GetDrawObjectType(buttonName);
                }
                else
                {
                    //선택되지 않은 버튼들의 배경 색은 원래대로 되돌린다.
                    item.Enabled = true;
                    item.BackColor = Color.FromArgb(255, 255, 255);
                }
            }

        }

        /// <summary>
        /// 버튼의 이름에 따라서 DrawObjectType 을 반환한다.
        /// </summary>
        /// <param name="buttonName">버튼 이름</param>
        /// <returns>DrawObjectType</returns>
        private DrawObjectType GetDrawObjectType(string buttonName)
        {
            switch (buttonName)
            {
                case "Select": return DrawObjectType.Select;        //커서
                case "Rectangle": return DrawObjectType.Rectangle;  //사각형
                case "Line": return DrawObjectType.Line;            //선
                case "Ellipse": return DrawObjectType.Ellipse;      //원
                case "Pencil": return DrawObjectType.Pencil;        //연필
            }
            //일치 이름 없으면 DrawObjectType.select 기본 반환
            return DrawObjectType.Select;
        }


        #endregion
        #region  ToolBar Strip 메뉴에 있는 도구들 Click


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SetToolBarButtonState(((ToolStripButton)e.ClickedItem).Text);
            
        }

        /// <summary>
        /// 새로 만들기
        /// </summary>
        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            //ObserverClass의 Action 에 ObserverAction을 입력한 후, 옵저버에게 알린다.
            observer.Action = ObserverAction.New;
            MainController.Instance.Notify(observer);

        }

        /// <summary>
        /// 파일 열기
        /// </summary>
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            //ObserverClass의 Action에 ObserverAction을 입력한 후, 옵저버에게 알린다.
            observer.Action = ObserverAction.FileLoad;
            MainController.Instance.Notify(observer);
        }
        /// <summary>
        /// 저장하기
        /// </summary>
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            //ObserverClass의 Action에 ObserverAction을 입력한 후, 옵저버에게 알린다.
            observer.Action = ObserverAction.FileSave;
            MainController.Instance.Notify(observer);
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            //실행 취소 할 항목이 있다면 실행
            if (MainController.Instance.Command.CanUndo)
            {
                //정상적으로 실행이 취소되었다면 옵저버에게 알린다.
                if (MainController.Instance.Command.Undo())
                {
                    MainController.Instance.Notify(ObserverAction.Invalidate);

                    //실행 취소와 다시 실행 버튼의 상태를 설정한다.
                    SetUndoRedoButton();
                }
            }
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            //다시 실행 할 항목이 있다면 실행
            if (MainController.Instance.Command.CanRedo)
            {
                //정상적으로 다시 실행 되었다면 옵저버에게 알린다.
                if (MainController.Instance.Command.Redo())
                {
                    MainController.Instance.Notify(ObserverAction.Invalidate);

                    //실행취소와 다시실행 버튼의 상태를 설정한다.
                    SetUndoRedoButton();
                }
            }
        }






        #endregion

       
    }
}
