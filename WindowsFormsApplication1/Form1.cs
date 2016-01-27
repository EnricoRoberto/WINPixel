using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class WINPixel : Form
    {
        public int larghezza;
        public int altezza;
        public bool visibility=true;

        SetFormSize ImpostaForm = new SetFormSize();

        public WINPixel()
        
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Name = "WINPixel";
            String strLarghezza;
            String strAltezza;
            this.Width = 300;
            this.Height = 300;
            textBoxWide.Text = "300";
            textBoxHeight.Text = "300";
            this.Location = new Point(100, 100);
            
            this.Opacity = 1;
            this.TopMost = true;

            strLarghezza = Convert.ToString(this.Width);
            strAltezza = Convert.ToString(this.Height);
            button2.Text = "Invisibile";
         }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
           //string message = "Puoi inserire solo numeri";
           //string caption = "Controllo Numeri Inseriti";
           //MessageBoxButtons buttons = MessageBoxButtons.OK;
           //DialogResult result;

           /// Displays the MessageBox.
           //result = MessageBox.Show(message, caption, buttons);
             
           //DialogResult = DialogResult.OK;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //string message = "Puoi inserire solo numeri";
            //string caption = "Controllo Numeri Inseriti";
            //MessageBoxButtons buttons = MessageBoxButtons.OK;
            //DialogResult result;

            /// Displays the MessageBox.
            //result = MessageBox.Show(message, caption, buttons);

            //DialogResult = DialogResult.OK;
        }

        public void button1_Click(object sender, EventArgs e)
        {
           
            ImpostaForm.imposta(textBoxHeight.Text, textBoxWide.Text, 300, 300);
            this.Width = ImpostaForm.larghezza;
            this.Height = ImpostaForm.altezza;

            textBoxWide.Text = Convert.ToString(ImpostaForm.larghezza);
            textBoxHeight.Text = Convert.ToString(ImpostaForm.altezza);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double valorevirgola;
            double valorevirgola100;
            int valorebarra = this.trackBar1.Value;
                     
            valorevirgola = Convert.ToDouble( this.trackBar1.Value);
            valorevirgola100 = valorevirgola / 100;
            textBox4.Text = Convert.ToString(valorevirgola100);
            this.Opacity = valorevirgola100;
            if (this.Opacity < 0.2)
            {
                this.Opacity = 0.2;
                textBox4.Text = Convert.ToString(this.Opacity);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            if (visibility == true)
            {
               
                textBoxWide.Visible = false;
                textBoxHeight.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                trackBar1.Visible = false;
                textBox4.Visible = false;
                visibility = false;
                button2.Text = "Visibile";

            }
            else
            {
                textBoxWide.Visible = true;
                textBoxHeight.Visible = true;
                button1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                trackBar1.Visible = true;
                textBox4.Visible = true;
                visibility = true;
                button2.Text = "Invisibile";
            }




        }
    }
}
