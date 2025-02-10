using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учебная_часть
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
//

//
            menuStrip1.ForeColor = Color.White;
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Личные дела");

            ToolStripMenuItem Vipush = new ToolStripMenuItem("Выпущенные") {  CheckOnClick = true };
            Vipush.CheckedChanged += menuItem_CheckedChanged1;
            fileItem.DropDownItems.Add(Vipush);
           
            

            ToolStripMenuItem Otchisl = new ToolStripMenuItem("Отчисленные") { CheckOnClick = true };
            Otchisl.CheckedChanged += menuItem_CheckedChanged2;
            fileItem.DropDownItems.Add(Otchisl);
          

            ToolStripMenuItem Pereved = new ToolStripMenuItem("Переведённые") { CheckOnClick = true };
            Pereved.CheckedChanged += menuItem_CheckedChanged3;
            fileItem.DropDownItems.Add(Pereved);
            

            menuStrip1.Items.Add(fileItem);
        }
        void menuItem_CheckedChanged1(object sender, EventArgs e)
        {
            
            menuStrip1.ForeColor = Color.White;
            
        }
        void menuItem_CheckedChanged2(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            menuStrip1.ForeColor = Color.White;
            
        }
        void menuItem_CheckedChanged3(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            menuStrip1.ForeColor = Color.White;
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip1.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavn f = new Glavn();
            f.Show();
            this.Hide();
        }
    }
}

    