using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheCat
{

    public partial class Form1 : Form
    {
        public Random rnd { get; set; } = new Random();
         
        public Form1()
        {
            InitializeComponent();
        }
         
    
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
          
            int x = rnd.Next(0, 1800);
            int y = rnd.Next(0, 1000);        

            pictureBox1.Location = new Point(x, y);

        }

         
    }
}
