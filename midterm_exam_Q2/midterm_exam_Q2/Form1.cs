using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_exam_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i >= 55 && i <= 67 && (i % 2 != 0))
                {                  
                    label1.Text +=  i.ToString() + " , " ;
                    sum += i;                    
                }
            }
            label1.Text +=  $"\n\n他們之間的和為{sum}";
        }
    }
}
