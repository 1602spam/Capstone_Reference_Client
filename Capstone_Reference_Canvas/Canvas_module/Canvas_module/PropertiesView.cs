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
    public partial class PropertiesView : Form
    {

        #region 전역 변수

        private const int maxWidth = 10;
        #endregion

        #region 속성
        
        //펜 두께
        public int PenWidth { get; set; }
        
        //테두리 색
        public Color Color { get; set; }

        //배경색
        public Color BackGroundColor { get; set; }


        #endregion

        #region 생성자
        public PropertiesView()
        {
            
        }

        public PropertiesView(Color color, Color backGroundColor, int penWidth = 1)
        {
            InitializeComponent();

            InitControls();
            label_BackgroundColor.BackColor = backGroundColor;
            label_Color.BackColor = color;
            combobox_PenWidth.Text = penWidth.ToString();
        }


        #endregion

        #region 이벤트
        

        //저장하기 버튼
        private void button_Save_Click(object sender, EventArgs e)
        {
            Controller.MainController.Instance.LastUsedColor = Color = Color.FromArgb(tb.Value, label_Color.BackColor.R, label_Color.BackColor.G, label_Color.BackColor.B);
            Controller.MainController.Instance.LastUesdBackgoroundColor = BackGroundColor = label_BackgroundColor.BackColor;
            Controller.MainController.Instance.LastUsedPenWidth = PenWidth = int.Parse(combobox_PenWidth.Text);

            this.DialogResult = DialogResult.OK;
        }


        //테두리 색 지정
        private void button_SelectColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = label_Color.BackColor;
            if(colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                label_Color.BackColor = colorDialog1.Color;
            }
        }

        //배경 색 지정
        private void button_SelectBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = label_BackgroundColor.BackColor;
            if(colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                label_BackgroundColor.BackColor = colorDialog1.Color;
            }
        }
        //취소하기
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = label_BackgroundColor.BackColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                label_BackgroundColor.BackColor = colorDialog1.Color;
            }
        }


        /// <summary>
        /// 콤보박스 초기화
        /// </summary>
        private void InitControls()
        {
            for (int i = 1; i <= maxWidth; i++)
            {
                combobox_PenWidth.Items.Add(i.ToString(CultureInfo.InvariantCulture));
            }
        }

        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblnum.Text = tb.Value.ToString();
        }
    }
}
