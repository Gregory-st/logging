﻿using System;
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
    public partial class Slovar : Form
    {
        public Slovar()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Glavn a = new Glavn();
                a.Show();
            this.Hide();
        }
    }
}
