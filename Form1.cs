using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void saiphLabel_Click(object sender, EventArgs e)
        {

        }

        private void alnitakLabel_Click(object sender, EventArgs e)
        {

        }

        private void displayStarNameButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = true;
            alnilamLabel.Visible = true;
            saiphLabel.Visible = true;
            alnitakLabel.Visible = true;
            mintakaLabel.Visible = true;   
            meissaLabel.Visible = true;
            rigelLabel.Visible = true;
        }

        private void hideStarNameButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = false;
            alnilamLabel.Visible = false;
            saiphLabel.Visible = false;
            alnitakLabel.Visible = false;
            mintakaLabel.Visible = false;
            rigelLabel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
