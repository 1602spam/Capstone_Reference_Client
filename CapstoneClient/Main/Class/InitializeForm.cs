using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Class
{
    public static class InitializeForm
    {
        //팝업 폼 초기화
        public static void InitializePopup(this Form f)
        {
            f.MaximizeBox = false;
            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.StartPosition = FormStartPosition.CenterScreen;
        }
        public static void InitializeAttachment(this Form f)
        {
            f.Dock = DockStyle.Fill;
        }

    }
}
