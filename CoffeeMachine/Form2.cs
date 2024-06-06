using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void EmptyButton_Click(object sender, EventArgs e)
        {
            EmptyProgressBar.Minimum = 0;
            EmptyProgressBar.Maximum = 100;
            EmptyProgressBar.Step = 1;


            while (EmptyProgressBar.Value < EmptyProgressBar.Maximum) 
            {
                EmptyProgressBar.Value += 1;
                System.Threading.Thread.Sleep(25);
            }
            Form1.condensation = false;
            this.Close();

        }
    }
}
