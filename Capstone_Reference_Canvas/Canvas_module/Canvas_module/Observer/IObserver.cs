using Canvas_module.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_module.Observer
{
    public interface IObserver
    {
        /// <summary>
        /// 옵저버로부터 수신된 내용을 ObserverAction에 따라 수행
        /// </summary>
        /// <param name="action">Invaildate, Command, New 등 </param>
        void OnNext(ObserverAction action);
        /// <summary>
        /// 옵저버로부터 수신된 내용이 있으면 ObserverName과 ObserverAction에 따라 실행
        /// </summary>
        /// <param name="obserber">ObserverClass로 ObserverName과 ObserverAction을 속성으로 가진다.</param>
        void OnNext(ObserverClass obserber);
    }

    
}
