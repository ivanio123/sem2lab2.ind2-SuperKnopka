using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem2._7._2._2_SuperKnopka_
{
    public partial class Form1 : Form
    {
        delegate void DelegateButton(object sender, EventArgs e);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity < 1f)
            {
                this.Opacity = 1f;
            }
            else
            {
                this.Opacity = 0.5f;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.ActiveCaption)
                this.BackColor = Color.OldLace; 
            else 
                this.BackColor = SystemColors.ActiveCaption; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
            DelegateButton[] buttons = new DelegateButton[] { button1_Click, button2_Click, button3_Click };
            if (checkBox1.Checked == true)
            {
                buttons[0](sender, e);
            }
            if (checkBox2.Checked == true)
            {
                buttons[1](sender, e);
            }
            if (checkBox3.Checked == true)
            {
                buttons[2](sender, e);
            }
        }
    }
}
