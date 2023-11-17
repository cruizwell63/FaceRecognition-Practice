using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace FaceRecognition_Practice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        FaceRec rc = new FaceRec();

        private void Form2_Load(object sender, EventArgs e)
        {
            rc.isTrained = true;
            label1.Hide();
            rc.getPersonName(label1);
            pictureBox2.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (db.present(label1.Text) == 1)
            {
                MessageBox.Show("Logged in successfully");
            }
            else
                MessageBox.Show("Log in failed.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rc.openCamera(pictureBox1, pictureBox2);
        }
    }
}
