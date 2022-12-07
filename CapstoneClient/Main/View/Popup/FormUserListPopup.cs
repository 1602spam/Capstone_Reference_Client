using Main.Class;
using ServerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.View.Popup
{
    public partial class FormUserListPopup : Form
    {
        private string lblIDDef = "";
        private int targetID = 0;
        delegate void RefreshCallback(int x, string y, bool z); //인수 사용 안 함
        public FormUserListPopup()
        {
            InitializeComponent();
            this.InitializePopup();

            /*
            foreach (var item in ClientContainer.Instance.loginDict)
            {
                string[] items = new string[] { item.Key.ToString(), item.Value.name}; 
                ListViewItem lvitem = new(items);
                listView1.Items.Add(lvitem);
            }
            */
            refreshListView(0,"test",false);
            lblIDDef = lblID.Text;

            if(ConnectInfo.user!=null)
                ConnectInfo.user.UserListEvent += refreshListView;
        }

        private void refreshListView(int num, string name, bool deleted)
        {
            if (this.listView1.InvokeRequired)
            {
                RefreshCallback c = new RefreshCallback(refreshListView);
                this.Invoke(c,0,"test",false);
            }
            else
            {
                if (ConnectInfo.user == null)
                    return;

                listView1.Items.Clear();
                /*
                foreach (var item in ClientContainer.Instance.loginDict)
                {
                    string[] items;
                    string id = item.Key.ToString();
                    if (id == "-1") { id = "교수"; }

                    items = new string[] { id, item.Value.name };

                    ListViewItem lvitem = new(items);
                    listView1.Items.Add(lvitem);
                }*/

                foreach (var item in ConnectInfo.user.userList)
                {
                    string[] items;
                    string id = item.Key.ToString();
                    if (id == "-1") { id = "교수"; }

                    items = new string[] { id, item.Value };

                    ListViewItem lvitem = new(items);
                    listView1.Items.Add(lvitem);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientContainer.Instance.blockSend == false)
            {
                DisableChat();
            }
            else
            {
                EnableChat();
            }
        }

        private void EnableChat()
        {
            lblChatable.Text = "채팅 허용됨";
            lblChatable.ForeColor = Color.Black;
            if (ConnectInfo.server!=null)
                ConnectInfo.server.SetMessageBlock(false);
        }

        private void DisableChat()
        {
            lblChatable.Text = "채팅 금지됨";
            lblChatable.ForeColor = Color.Red;
            if (ConnectInfo.server != null)
                ConnectInfo.server.SetMessageBlock(true);
        }

        private void btnPrtUserList_Click(object sender, EventArgs e)
        {
            ClientContainer.Instance.PrtUsers();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ClientContainer.Instance.KickUser(targetID);
            ClientContainer.Instance.RemoveUser(ClientContainer.Instance.loginDict[ConnectInfo.user.studentID], targetID);
            lblID.Text = lblIDDef;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetID = 0;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                //MessageBox.Show(item.Text);
                int.TryParse(item.Text, out targetID);
                break;
            }
            if (targetID > 0)
                lblID.Text = lblIDDef + targetID.ToString();
            else
                lblID.Text = lblIDDef;
        }
    }
}
