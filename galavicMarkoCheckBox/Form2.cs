using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galavicMarkoCheckBox
{
    public partial class checkBox : Form
    {
        public checkBox()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dorucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rucak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Posalji_TextChanged(object sender, EventArgs e)
        {
          

            
           

        }

        private void Sakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (!sakrij.Checked)
            {
            
               
            
                if (dorucak.Checked)
                {
                    prikaz.AppendText("Odabrali ste doručak.");
                }
                if (rucak.Checked)
                {
                    prikaz.AppendText("\r\nOdabrali ste ručak.");
                }
                if (vecera.Checked)
                {
                    prikaz.AppendText("\r\nOdabrali ste večeru.");
                }
               
            }
            else
            {
                prikaz.Clear();
            }
        }

        private void Posalji_Click(object sender, EventArgs e)
        {
            if (dorucak.Checked)
            {
                prikaz.AppendText("Odabrali ste doručak.");
            }
            if (rucak.Checked)
            {
                prikaz.AppendText("\r\nOdabrali ste ručak.");
            }
            if (vecera.Checked)
            {
                prikaz.AppendText("\r\nOdabrali ste večeru.");
            }
        }
    }
}
