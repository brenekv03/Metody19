using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private static void Proved(ListBox listBox, int zadaneCislo)
        {
            int pc = 0;
            int sc = 0;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                int x = int.Parse(listBox.Items[i].ToString());
                if (x % 2 == 0)
                {
                    pc++;
                    sc += x;
                    listBox.Items[i] = 0;
                }
                else
                {
                    x *= zadaneCislo;
                    listBox.Items[i] = x;
                }
            }
            double prumer = (double)sc / pc;
            int indexprumer = listBox.Items.Count;
            listBox.Items.Add(prumer);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1.Proved(listBox1, 5);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
  
}
