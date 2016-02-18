using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState        =   FormWindowState.Maximized;
        }

        public void AddMenu() { 
            MainMenu menus          =   new MainMenu();
            this.Menu               =   menus; 
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chartOfAccountsAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart form_ChartAdmin   =   new Chart();
            form_ChartAdmin.ShowDialog();
        }    
    }
}
