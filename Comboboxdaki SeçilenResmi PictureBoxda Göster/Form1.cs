using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comboboxdaki_SeçilenResmi_PictureBoxda_Göster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1") pictureBox1.ImageLocation = "1.jpg";
            else if (comboBox1.Text == "2") pictureBox1.ImageLocation = "2.jpg";
            else if (comboBox1.Text == "3") pictureBox1.ImageLocation = "3.jpg";
            else if (comboBox1.Text == "4") pictureBox1.ImageLocation = "4.jpg";
            else if (comboBox1.Text == "5") pictureBox1.ImageLocation = "5.jpg";
            else if (comboBox1.Text == "6") pictureBox1.ImageLocation = "6.jpg";
            else if (comboBox1.Text == "7") pictureBox1.ImageLocation = "7.jpg";
            else if (comboBox1.Text == "8") pictureBox1.ImageLocation = "8.jpg";
            else pictureBox1.ImageLocation = "";
           
        }
    }
}
