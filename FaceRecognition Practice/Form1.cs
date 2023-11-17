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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            FaceRec rc = new FaceRec();
            rc.openCamera(pictureBox1,pictureBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FaceRec rc = new FaceRec();

            if (textBox1.Text != "")
            {
                rc.Save_IMAGE(textBox1.Text);
                db.isSave(textBox1.Text);
                MessageBox.Show("Saved Successfully", "Saved");

            }
            else {
                MessageBox.Show("Please fill name");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FaceRec rc = new FaceRec();
            rc.isTrained = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}
