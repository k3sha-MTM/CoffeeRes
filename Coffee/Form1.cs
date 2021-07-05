using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelAmericano = new Label();   
            this.labelAmericano.Text = "This is Americano: " +
                "50% water " +
                "50% coffe";
            this.labelAmericano.Location = new Point(200,400);
            this.labelAmericano.Size = new Size(100,50);
           
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.labelCapuchino = new Label();
            this.labelCapuchino.Text = "This is Americano: " +
                "50% water " +
                "50% coffe";
            this.labelCapuchino.Location = new Point(200, 400);
            this.labelCapuchino.Size = new Size(100, 50);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.labelLatte = new Label();
            this.labelLatte.Text = "This is Americano: " +
                "50% water " +
                "50% coffe";
            this.labelLatte.Location = new Point(200, 400);
            this.labelLatte.Size = new Size(100, 50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.labelEspresso = new Label();
            this.labelEspresso.Text = "This is Americano: " +
                "90% water " +
                "10% coffe";
            this.labelEspresso.Location = new Point(200, 400);
            this.labelEspresso.Size = new Size(100, 50);
        }
    }
           
}
