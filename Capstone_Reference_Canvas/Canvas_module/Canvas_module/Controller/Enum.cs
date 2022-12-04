using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// 사용자 정의 변수 모음 클래스
namespace Canvas_module.Controller
{
    public enum ObserverAction
    {
        Invalidate,   //다시 그리기
        Command,      //실행취소와 다시실행
        Rectangle,    //사각형
        Ellipse,      //원
        Line,         //줄
        Pencil,       //연필
        TextBox,
        Select,       //선택
        FileLoad,     //불러오기
        FileSave,     //저장하기
        New,          //새로 만들기
        LastTool      //마지막에 사용한 도구
    }

    public enum ObserverName
    {
        MainView, //메인 화면
        DrawBox, //그리기 상자
        ToolBar //상단 툴바
    }

    /// <summary>
    /// 그리기와 관련된 객체의 타입
    /// </summary>
    public enum DrawObjectType
    {
        Rectangle,  //사각형
        Ellipse,    //원
        Line,       //줄
        Pencil,     //연필
        Select,     //선택
        TextBox     //텍스트 박스    
    };

    /// <summary>
    /// DrawBox 에서 현재 선택된 상태
    /// </summary>
    public enum SelectMode
    {
        None,            //아무것도 선택되지 않음
        NetSelection,   //영역으로 선택
        Move,           //이동
        Size,           //사이즈 변경
        InsertText      //텍스트 삽입
    };
}
