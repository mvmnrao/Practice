using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("SNo", typeof(string)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));

            DataRow dr = dt.NewRow();
            dr[0] = "1";
            dr[1] = "First Row";
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1[0] = "2";
            dr1[1] = "Second Row";
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2[0] = "3";
            dr2[1] = "Third Row";
            dt.Rows.Add(dr2);

            dGVForContext.DataSource = dt;            
        }

        private void dGVForContext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void dGVForContext_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //MessageBox.Show("Mouse Right Click");

                System.Windows.Forms.ContextMenu myMenu = new System.Windows.Forms.ContextMenu();
                myMenu.MenuItems.Add(new MenuItem(dGVForContext.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
                Point po = this.PointToClient(Cursor.Position);
                myMenu.Show(this, po, LeftRightAlignment.Right);
        

                //ContextMenuStrip cm = new System.Windows.Forms.ContextMenuStrip();
                //cm.Items.Add(dGVForContext.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                //DataGridViewCell cel = dGVForContext.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //cm.Show(dGVForContext, e.Location, LeftRightAlignment.Right);
                
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MessageBox.Show("Mouse Click");
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {
                MessageBox.Show("Mouse Middle Click");
            }
            else
            {
                MessageBox.Show("Other Mouse Button Clicked");
            }
        }
    }
}
