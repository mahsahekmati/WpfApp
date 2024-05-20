using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datamodel;

namespace anbardari.window
{
    public partial class win_systempart : Form
    {
        public win_systempart()
        {
            InitializeComponent();
        }
        anbardariEntities database=new anbardariEntities();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void win_systempart_Load(object sender, EventArgs e)
        {
            lbl_title.Parent=pictureBox1 ;
            treeview_part.Parent=pictureBox1 ;
            btn_create.Parent=pictureBox1 ;
            btn_exit.Parent=pictureBox1 ;
        }

        private void win_systempart_Activated(object sender, EventArgs e)
        {
            treeview_part.Nodes.Clear();
            TreeNode tn = new TreeNode("حقوق دسترسی سیستم");
            tn.ForeColor = Color.Red;
            tn.Tag = "1";
            treeview_part.Nodes.Add(tn);
            ///////////////////
            LoadTreeView(tn);

        }


        private void LoadTreeView(TreeNode TN)
        {

            int TagInt;
            TagInt = Convert.ToInt32(TN.Tag);
            /////////////////////////////////////////////////////////////////////////
            var query = from SPF in database.v_systempart
                        where SPF.systempartlevel == TagInt
                        select SPF;
            var users = query.ToList();

            if (users.Count > 0)
            {
                for (int I = 0; I < users.Count; I++)
                {
                    TreeNode M = new TreeNode();
                    M.Tag = users[I].systempartid;
                    M.Text = M.Tag + " - " + users[I].systempartname;
                    M.ToolTipText = "" + M.Tag;

                    if (TN.Level < this.imageList.Images.Count - 1)
                    {
                        M.ImageIndex = TN.Level + 1;
                        M.SelectedImageIndex = TN.Level + 1;
                    }
                    else
                    {
                        M.ImageIndex = this.imageList.Images.Count - 1;
                        M.SelectedImageIndex = this.imageList.Images.Count - 1;
                    }
                    TN.Nodes.Add(M);
                    int CH = Convert.ToInt32(users[I].childcount);
                    if (CH > 0)
                    {
                        LoadTreeView(M);
                    }
                    M = null;
                }
            }

        }
    }
}
