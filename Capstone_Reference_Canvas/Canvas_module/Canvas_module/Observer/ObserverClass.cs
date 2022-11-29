using Canvas_module.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_module.Observer
{
  public class ObserverClass
    {
        #region 생성자

        public ObserverClass(string name)
        {
            Name = GetName(name);
        }

        #endregion

        #region 내부 함수
        private ObserverName GetName(string name)
        {
            switch (name)
            {

                case "MainView": return ObserverName.MainView;
                case "ToolBar": return ObserverName.ToolBar;
                case "DrawBox": return ObserverName.DrawBox;
            }

            return ObserverName.MainView;
                    
        }
        #endregion

        #region 속성
        public ObserverName Name { get; set; }
        public ObserverAction Action { get; set; }
        #endregion
    }
}
