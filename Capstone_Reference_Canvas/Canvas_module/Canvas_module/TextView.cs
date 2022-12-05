using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas_module
{
    public partial class TextView : Form
    {

        #region 전역변수

        #endregion

        #region 속성

        public string Text { get; set; }

        #endregion

        #region 생성자
        public TextView()
        {
            
        }

        public TextView(string text)
        {
            InitializeComponent();
            textBox1.Text = text;
        }

        #endregion


        #region 이벤트

        private void savebutton_Click(object sender, EventArgs e)
        {
            Text = this.textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }

        #endregion

        private void TextView_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                savebutton_Click(sender, e);
            }
        }
    }
}
