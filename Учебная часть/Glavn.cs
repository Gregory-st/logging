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
    public partial class Glavn : Form
    {
        public Glavn()
        {
            InitializeComponent();
            //Личные дела
            menuStrip1.ForeColor = Color.White;
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Личные дела");
          
            ToolStripMenuItem Obchie = new ToolStripMenuItem("Личное дело студента") { CheckOnClick = true };
            Obchie.CheckedChanged += menuItem_CheckedChanged1;
            fileItem.DropDownItems.Add(Obchie);
            //-------------
            ToolStripMenuItem Vipush = new ToolStripMenuItem("Выпущенные") { CheckOnClick = true };
            Vipush.CheckedChanged += menuItem_CheckedChanged2;
            fileItem.DropDownItems.Add(Vipush);
            //-------------
            ToolStripMenuItem Otchisl = new ToolStripMenuItem("Отчисленные") { CheckOnClick = true };
            Otchisl.CheckedChanged += menuItem_CheckedChanged3;
            fileItem.DropDownItems.Add(Otchisl);
            //-------------
            ToolStripMenuItem Pereved = new ToolStripMenuItem("Переведённые") { CheckOnClick = true };
            Pereved.CheckedChanged += menuItem_CheckedChanged4;
            fileItem.DropDownItems.Add(Pereved);
            //-------------
            menuStrip1.Items.Add(fileItem);

            // Отчисление и Перевод
            menuStrip2.ForeColor = Color.White;
            ToolStripMenuItem fileeItem = new ToolStripMenuItem("Отчисление и перевод");
            //-------------
            ToolStripMenuItem Otchislenie = new ToolStripMenuItem("Отчисление") { CheckOnClick = true };
            Otchislenie.CheckedChanged += menuItem_CheckedChanged5;
            fileeItem.DropDownItems.Add(Otchislenie);
            //-------------
            ToolStripMenuItem Perevod = new ToolStripMenuItem("Перевод") { CheckOnClick = true };
            Perevod.CheckedChanged += menuItem_CheckedChanged6;
            fileeItem.DropDownItems.Add(Perevod);
            menuStrip2.Items.Add(fileeItem);
        }
        void menuItem_CheckedChanged1(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
            Lich_delo_studenta a = new Lich_delo_studenta();
            a.Show();
            this.Hide();
        }
        void menuItem_CheckedChanged2(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            menuStrip1.ForeColor = Color.White;
            Lich_delo_Vipusk a = new Lich_delo_Vipusk();
            a.Show();
            this.Hide();
        }
        void menuItem_CheckedChanged3(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            menuStrip1.ForeColor = Color.White;
            Lich_delo_Otchisl a = new Lich_delo_Otchisl();
            a.Show();
            this.Hide();
        }
        void menuItem_CheckedChanged4(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            menuStrip1.ForeColor = Color.White;
            Lich_delo_Perevod a = new Lich_delo_Perevod();
            a.Show();
            this.Hide();
        }
        void menuItem_CheckedChanged5(object sender, EventArgs e)
        {
            ToolStripMenuItem Otchislenie = sender as ToolStripMenuItem;
            menuStrip2.ForeColor = Color.White;
            Otchislenie a = new Otchislenie();
            a.Show();
            this.Hide();

        }
        void menuItem_CheckedChanged6(object sender, EventArgs e)
        {
            ToolStripMenuItem Perevod = sender as ToolStripMenuItem;
            menuStrip2.ForeColor = Color.White;
            Perevod a = new Perevod();
            a.Show();
            this.Hide();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip1.ForeColor = Color.Black;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip2.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void Personal_dann_Click(object sender, EventArgs e)
        {
            Personal_dann a = new Personal_dann();
            a.Show();
            this.Hide();
        }

        private void Gruppa_Click(object sender, EventArgs e)
        {
            Gruppa a = new Gruppa();
            a.Show();
            this.Hide();
            
        }

        private void Slovar_Click(object sender, EventArgs e)
        {
            Slovar a = new Slovar();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
