using Canvas_module.Observer;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Canvas_module.Controller
{
    public sealed class MainController : IObservable
    {

        #region 전역변수

        /// <summary>
        /// 싱글톤 패턴을 위한 인스턴스
        /// </summary>
        private static MainController? instance = null;

        /// <summary>
        /// 현재 Canvas에서 그려지는 DrawObject를 저장하는 Collection
        /// </summary>
        private Model.Graphic graphicModel = new Model.Graphic();
        private static readonly object padlock = new object();

        /// <summary>
        /// IObserver 를 상속받은 객체를 관리하기 위한 컬렉션
        /// </summary>
        private List<IObserver> listener = new List<IObserver>();

        /// <summary>
        /// Undo, Redo 관리 Command 클래스
        /// </summary>
        private Command.Command command = new Command.Command();

        /// <summary>
        /// 최근에 사용한 Pen의 두께
        /// </summary>
        private int lastUsedPenWidth = 1;

        /// <summary>
        /// 최근에 사용한 테두리의 색
        /// </summary>
        private Color lastUsedColor = Color.Black;

        /// <summary>
        /// 최근에 사용한 배경색
        /// </summary>
        private Color lastUsedBackColor = Color.White;
        #endregion

        #region 생성자
        MainController()
        {

        }

        /// <summary>
        /// 인스턴스 반환
        /// </summary>
        public static MainController Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new MainController();
                        }
                    }
                }

                return instance;
            }
        }

        #endregion

        #region 옵저버 패턴
        /// <summary>
        /// 옵저버에 등록된 구독자들에게 ObserverAction 을 전달
        /// 전달은 받은 구독자들은 ObserverAction 에 따라서 적절한 행동을 한다.
        /// </summary>
        public void Notify(ObserverAction action)
        {
            foreach (IObserver item in listener)
            {
                item.OnNext(action);
            }
        }

        /// <summary>
        /// 옵저버에 등록된 구독자들에게 ObserverClass 를 전달
        /// 전달은 받은 구독자들은 ObserverClass 의 ObserverName 과 ObserverAction 에 따라서 적절한 행동을 한다.
        /// </summary>
        public void Notify(ObserverClass observer)
        {
            foreach (IObserver item in listener)
            {
                item.OnNext(observer);
            }
        }

        /// <summary>
        /// Listner에 IObserver를 상속받은 구독자들을 등록한다.
        /// </summary>
        public IDisposable Subscribe(IObserver observer)
        {
            listener.Add(observer);

            return listener as IDisposable;
        }

        /// <summary>
        /// Listner에 등록된 IObserver를 상속받은 구독자를 해제한다.
        /// </summary>
        /// <param name="observer"></param>
        public void Unsubscribe(IObserver observer)
        {
            listener.Remove(observer);
        }
        #endregion

        #region 속성
        /// <summary>
        /// 최근에 사용한 Pen 의 두께
        /// </summary>
        public int LastUsedPenWidth
        {
            get
            {
                return lastUsedPenWidth;
            }

            set
            {
                lastUsedPenWidth = value;
            }
        }

        /// <summary>
        /// 최근에 사용한 배경색
        /// </summary>
        public Color LastUesdBackgoroundColor
        {
            get
            {
                return lastUsedBackColor;
            }

            set
            {
                lastUsedBackColor = value;
            }
        }

        /// <summary>
        /// 최근에 사용한 테두리의 색
        /// </summary>
        public Color LastUsedColor
        {
            get
            {
                return lastUsedColor;
            }

            set
            {
                lastUsedColor = value;
            }
        }

        public Command.Command Command
        {
            get
            {
                return command;
            }

            set
            {
                command = value;
            }
        }

        public Model.Graphic GraphicModel
        {
            get
            {
                return this.graphicModel;
            }

            set
            {
                this.graphicModel = value;
            }
        }

        public DrawObjectType DrawObjectType
        {
            get; set;
        }

        public SelectMode SelectMode
        {
            get; set;
        }
        #endregion
    }
}
