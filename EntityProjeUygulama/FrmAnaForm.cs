﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrun fru = new FrmUrun();
            fru.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmIstatistik fri = new FrmIstatistik();
            fri.Show();
        }

        private void FrmAnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
