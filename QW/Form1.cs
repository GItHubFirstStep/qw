﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Q qq = new Q();//测试同步2
            qq.Show();//获取7
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Q";
        }
    }
}
