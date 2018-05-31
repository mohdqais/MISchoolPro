using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamic_checkboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            CheckBox box;
            for (int i = 0; i < 10; i++)
            {
                box = new CheckBox();
                box.Tag = i.ToString();
                box.Text = "Test 1";
                box.AutoSize = true;
                box.Location = new Point(50, i * 20); //vertical
                //box.Location = new Point(i * 50, 10); //horizontal
                panel2.Controls.Add(box);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }
    }
}
