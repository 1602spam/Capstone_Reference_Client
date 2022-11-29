using Canvas_module.Controller;
using Canvas_module.DrawObjects;
using System;
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
        /// 실행 취소(Undo) 스택
        /// List<DrawObject> 를 스택으로 쌓는다.
        /// </summary>
        private Stack<List<DrawObject>> undoStack = new Stack<List<DrawObject>>();

        /// <summary>
        /// 다시 실행(Redo) 스택
        /// List<DrawObject> 를 스택으로 쌓는다.
        /// </summary>
        private Stack<List<DrawObject>> redoStack = new Stack<List<DrawObject>>();
        #endregion

        #region 속성

        /// <summary>
        /// 실행 취소 가능 여부
        /// </summary>
        public bool CanUndo
        {
            get { return undoStack.Count > 0; }
        }
        
        public bool CanRedo
        {
            get { return redoStack.Count > 0; }
        }

        #endregion

        #region 내부함수


        /// <summary>
        /// Command 추가 => 실행취소(Undo) 스택에 List<DrawObjects.DrawObject>를 추가한다.
        /// </summary>
        /// <param name="data">List<DrawObjects.DrawObject></param>
        public void AddCommand(List<DrawObjects.DrawObject> data)
        {
            //실행취소(Undo) 스택에 추가
            undoStack.Push(DataClone(data));

            //Command 가 추가 되었음을 옵저버에게 알린다.
            MainController.Instance.Notify(ObserverAction.Command);
        }

        /// <summary>
        /// 실행취소(Undo)
        /// 실행 취소 후 실행 취소 여부를 bool 값으로 반환
        /// </summary>
        /// <returns>true or false</returns>
        public bool Undo()
        {
            if (CanUndo)
            {
                //Redo 스택에 현재 GrapList를 넣어준다.
                redoStack.Push(DataClone(MainController.Instance.GraphicModel.GrapList));

                MainController.Instance.GraphicModel.GrapList = DataClone(undoStack.Pop());

                return true;
            }

            return false;
        }

   
        /// <summary>
        /// 다시 실행(redo)
        /// 다시 실행 후 다시 실행 여부를 bool 값 반환.
        /// </summary>
        /// <returns>true or false</returns>
        public bool Redo()
        {
            if (CanRedo)
            {
                undoStack.Push(DataClone(MainController.Instance.GraphicModel.GrapList));

                MainController.Instance.GraphicModel.GrapList = DataClone(redoStack.Pop());
                return true;
            }
            return false;
        }

        /// <summary>
        /// 실행취소(Undo) 와 다시실행(Redo) 스택을 비운다.
        /// </summary>
        public void Clear()
        {
            undoStack.Clear();
            redoStack.Clear();
        }

        private List<DrawObject> DataClone(List<DrawObject> drawObjects)
        {
            List<DrawObject> dataclone = new List<DrawObject>();

            foreach(DrawObject item in drawObjects)
            {
                dataclone.Add(item.Clone());
            }

            return dataclone;
        }
        #endregion

    }
}
