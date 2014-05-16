using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmUserRoleAssign : System.Windows.Forms.Form
    {
        public frmUserRoleAssign()
        {
            InitializeComponent();
        }
        private User _objCurrentUser;
        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        public frmUserRoleAssign(MenuStrip ms)
        {
            InitializeComponent();
            menuStrip1 = ms;
        }

        public frmUserRoleAssign(MenuStrip ms,User objUser)
        {
            InitializeComponent();
            menuStrip1 = ms;
            CurrentUser = objUser;
        }

        MenuStrip menuStrip1 = new MenuStrip();
        public static string nodeClicked;
        SqlDataAdapter adp = new SqlDataAdapter(null);
        ArrayList arrayOfMenuItems = new ArrayList();
        UserRole_DL objUserRoleDL = new UserRole_DL(ConnectionStringClass.GetConnection());
        UserRole objUserRole = new UserRole();
        UserAccessRights_DL objUserAccessRightsDL = new UserAccessRights_DL(ConnectionStringClass.GetConnection());
        DataTable dt = new DataTable();

        UserAccessRightsCollec objUserAccessRightsCollec = new UserAccessRightsCollec();


        private void addnode(TreeNode node, ToolStripItem item)
        {
            try
            {
                if (item.GetType().Equals(typeof(ToolStripMenuItem)))
                {
                    if (node == null)
                    {
                        node = treeView1.Nodes.Add(item.Text);
                        node.Name = item.Name;
                    }
                    else
                    {
                        node = node.Nodes.Add(item.Text);
                        node.Name = item.Name;
                    }
                    IEnumerator ie = ((ToolStripMenuItem)item).DropDownItems.GetEnumerator();
                    while (ie.MoveNext())
                        addnode(node, (ToolStripItem)ie.Current);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "addnode()");
            }
        }

        public void build(MenuStrip menuStrip, TreeView treeView)
        {
            try
            {
                IEnumerator ie = menuStrip.Items.GetEnumerator();
                while (ie.MoveNext())
                {
                    addnode(null, (ToolStripItem)ie.Current);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "build()");
            }
        }

        public void SaveNode(TreeNode node)
        {
            
            UserAccessRights obj = new UserAccessRights();

            obj.MenuID = node.Name;
            obj.MenuName = node.Text;
            if (node.Checked)
            {
                obj.Permission = "Active";
            }
            else
            {
                obj.Permission = "InActive";
            }
            obj.UserRoleID = objUserRole.UserRoleID;
            objUserAccessRightsDL.Add(obj);

            for (int i = 0; i < node.Nodes.Count; i++)
            {
                SaveNode(node.Nodes[i]);
            }
        }

        public void SaveTree()
        {
            if (treeView1.Nodes.Count > 0)
            {
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {
                    SaveNode(treeView1.Nodes[i]);
                }
            }
            else
            {
                MessageBox.Show(this,"The Treeview control does not have any node(s).","Empty Tree",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void LoadTree(long RoleID)
        {
            UserAccessRightsCollec objCollec = new UserAccessRightsCollec();
            objCollec = objUserAccessRightsDL.Get(RoleID);

            foreach (UserAccessRights obj in objCollec)
            {
                if (treeView1.Nodes.Count > 0)
                {
                    for (int i = 0; i < treeView1.Nodes.Count; i++)
                    {
                        LoadNode(treeView1.Nodes[i],obj);
                    }
                }
            }
        }

        public void LoadNode(TreeNode node,UserAccessRights obj)
        {
            if (node.Name == obj.MenuID)
            {
                if (obj.Permission.Equals("Active"))
                {
                    node.Checked = true;
                }
                else
                {
                    node.Checked = false;
                }
            }
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                LoadNode(node.Nodes[i],obj);
            }
        }

        private void CheckBoxSelect(TreeView tview,bool Select)
        {
            if (treeView1.Nodes.Count > 0)
            {
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {
                    NodeSelect(treeView1.Nodes[i],Select);
                }
            }
        }

        private void NodeSelect(TreeNode node, bool Select)
        {
            node.Checked = Select;
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                NodeSelect(node.Nodes[i],Select);
            }
        }

        private void Clear()
        {
            textBox1.Text = "";
            objUserRole = new UserRole();
            CheckBoxSelect(treeView1, false);
            treeView1.CollapseAll();
            cbEdit.Checked = false;
            cbRemove.Checked = false;
        }

        private void frmUserRoleAssign_Load(object sender, EventArgs e)
        {
            try
            {

                dt.Columns.Add("Node Text", typeof(String));
                dt.Columns.Add("Node Name", typeof(String));
                dt.Columns.Add("User", typeof(long));
                dt.Columns.Add("Status", typeof(String));

                build(menuStrip1, treeView1);
                bindUserRoleList.DataSource = objUserRoleDL.GetDataview();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show(this, "Please fill the Name field", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    objUserRole.UserRoleName = textBox1.Text;
                    objUserRole.UserRoleID = objUserRoleDL.Add(objUserRole);
                    objUserRole.Edit = cbEdit.Checked;
                    objUserRole.Remove = cbRemove.Checked;
                    if (objUserRole.UserRoleID > 0)
                     {

                         SaveTree();
                         Clear();
                         bindUserRoleList.DataSource = objUserRoleDL.GetDataview();
                         MessageBox.Show(this,"Successfully Saved","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     }
                     

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (objUserRole.UserRoleID <= 0)
                {
                    MessageBox.Show(this,"Please Select a User Role","Empty Selection",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dr = MessageBox.Show(this,"Are you sure you want to delete selected user role?\n\nClick Yes to delete","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        objUserRoleDL.Delete(objUserRole.UserRoleID);
                        bindUserRoleList.DataSource = objUserRoleDL.GetDataview();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvUserRoleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objUserRole = objUserRoleDL.Get(Convert.ToInt64(gvUserRoleList.Rows[e.RowIndex].Cells[0].Value));
                textBox1.Text = objUserRole.UserRoleName;

                cbRemove.Checked = objUserRole.Remove;
                cbEdit.Checked = objUserRole.Edit;
                
                LoadTree(objUserRole.UserRoleID);


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void collapsAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBoxSelect(treeView1, true);
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBoxSelect(treeView1, false);
        }


    }
}