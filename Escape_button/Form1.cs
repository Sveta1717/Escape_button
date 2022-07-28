using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ха-ха!");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {            
            Random random = new Random();
            Button b = sender as Button;
           
            int x = random.Next(500);
            int y = random.Next(300);
            b.Location = new Point(x, y);
        }       
    }
}
