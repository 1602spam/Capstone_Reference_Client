using Canvas_module.Controller;
using Canvas_module.DrawObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_module.Command
{
    public class Command
    {
        #region 전역변수

        /// <summary>
        /// 실행취소(Undo) 스택
        /// List<DrawObject> 를 스택으로 쌓는다.
        /// </summary>
        private Stack<List<DrawObjects.DrawObject>> undoStack = new Stack<List<DrawObjects.DrawObject>>();

        /// <summary>
        /// 다시실행(Redo) 스택
        /// List<DrawObject> 를 스택으로 쌓는다.
        /// </summary>
        private Stack<List<DrawObjects.DrawObject>> redoStack = new Stack<List<DrawObjects.DrawObject>>();

        // undo list 
        public List<List<DrawObject>> undoList = new List<List<DrawObject>>();

        // redo list
        public List<List<DrawObject>> redoList = new List<List<DrawObject>>();

       
        #endregion

        #region 속성

        

        /// <summary>
        /// 실행취소(Undo) 가능 여부 
        /// </summary>
        public bool CanUndo
        {
            get { return undoList.Count > 0; }
        }


        /// <summary>
        /// 다시실행(Redo) 가능 여부
        /// </summary>
        public bool CanRedo
        {
            get { return redoList.Count > 0; }
        }

 
        #endregion

        #region 내부 함수

        /// <summary>
        /// Command 추가 => 실행취소(Undo) 스택에 List<DrawObjects.DrawObject>를 추가한다.
        /// </summary>
        /// <param name="data">List<DrawObjects.DrawObject></param>
        public void AddCommand(List<DrawObjects.DrawObject> data)
        {
         
            //실행취소(Undo) list에 추가
            undoList.Add(DataClone(data));
         
            //Command 가 추가 되었음을 옵저버에게 알린다.
            MainController.Instance.Notify(ObserverAction.Command);
        }

        

        /// <summary>
        /// 실행취소(Undo) 와 다시실행(Redo) 스택을 비운다.
        /// </summary>
        public void Clear()
        {
            undoStack.Clear();
            redoStack.Clear();

            //list
            undoList.Clear();
            redoList.Clear();
        }


        /// <summary>
        /// 실행취소(Undo)
        /// 실행취소 후 실행취소 여부를 bool 값으로 반환한다.
        /// </summary>
        /// <returns>true or false</returns>
        public bool Undo()
        {
            if (CanUndo)
            {              
                redoList.Add(DataClone(MainController.Instance.GraphicModel.GrapList));
               
                MainController.Instance.GraphicModel.GrapList = DataClone(undoList.Last());
                undoList.RemoveAt(undoList.Count - 1);


                return true;
            }
            return false;

        }

       

        /// <summary>
        /// 다시실행(Redo)
        /// 다시실행 후 다시실행 여부를 bool 값으로 반환한다.
        /// </summary>
        /// <returns>true or false</returns>
        public bool Redo()
        {
            if (CanRedo)
            {
                undoList.Add(DataClone(MainController.Instance.GraphicModel.GrapList));

                MainController.Instance.GraphicModel.GrapList = DataClone(redoList.Last());
                redoList.RemoveAt(redoList.Count - 1);

                return true;
            }

            return false;
        }

       

        /// <summary>
        /// List<DrawObjects.DrawObject> 을 복사하여 반환한다.
        /// </summary>
        /// <param name="data">List<DrawObjects.DrawObject></param>
        /// <returns>List<DrawObjects.DrawObject></returns>
        private List<DrawObjects.DrawObject> DataClone(List<DrawObjects.DrawObject> data)
        {
            List<DrawObject> clone = new List<DrawObject>();

            foreach (DrawObject item in data)
            {
                clone.Add(item.Clone());
            }

            return clone;
        }

        #endregion
    }
}
