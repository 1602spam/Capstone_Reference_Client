using Canvas_module.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canvas_module.DrawObjects;

namespace Canvas_module.Model
{ 

    [Serializable]
    public class Graphic
    {
        #region 전역변수

        /// <summary>
        /// DrawObject 형 List
        /// </summary>
        private List<DrawObject> grapList = new List<DrawObject>();

        #endregion

        #region 속성

        public List<DrawObject> GrapList
        {
            get
            {
                return grapList;
            }

            set
            {
                grapList = value;
            }
        }


        public int SelectedCount
        {
            get 
            { int i = 0;
                foreach(DrawObject obj in grapList)
                {
                    if (obj.Selected)
                    {
                        i++;
                    }
                }

                return i = 0;
            }
        }
        #endregion
    }


}
