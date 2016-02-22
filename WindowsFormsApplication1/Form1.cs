using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;

namespace WindowsFormsApplication1
{
    public partial class WINPixel : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public int larghezza;
        public int altezza;
        public bool visibility=true;
       
        SetFormSize ImpostaForm = new SetFormSize();
        DataInsertionCeck DataCeck = new DataInsertionCeck();
        private bool nonNumberEntered = false;
        
        public override Color BackColor { get; set; }

        static int valore=0;

        private volatile bool _shouldStop;

        public WINPixel()
        
        {
            InitializeComponent();
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
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

            timer1.Interval = 500;
            timer1.Enabled = true;
                        

    }

      
               
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                        
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
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
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
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                trackBar1.Visible = true;
                textBox4.Visible = true;
                visibility = true;
                button2.Text = "Invisibile";
            }




        }

        private void textBoxWide_KeyDown(object sender, KeyEventArgs e)
        {

            {
                // Initialize the flag to false.
         
                nonNumberEntered = false;
                
                // Determine whether the keystroke is a number from the top of the keyboard. 
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    // Determine whether the keystroke is a number from the keypad. 
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        // Determine whether the keystroke is a backspace. 
                        if (e.KeyCode != Keys.Back)
                        {
                            if (e.KeyCode != Keys.Enter)
                            {
                                // A non-numerical keystroke was pressed. 
                                // Set the flag to true and evaluate in KeyPress event.
                                nonNumberEntered = true;
                            }
                        }
                    }
                }
                //If shift key was pressed, it's not a number. 
                if (Control.ModifierKeys == Keys.Shift)
                {
                    nonNumberEntered = true;
                }
            }

        }

        private void textBoxWide_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Check for the flag being set in the KeyDown event. 
                if (nonNumberEntered == true)
                {

                    string message = "Puoi inserire solo numeri";
                    string caption = "Controllo Numeri Inseriti";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    //Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    DialogResult = DialogResult.OK;
                    
                    //Stop the character from being entered into the control since it is non-numerical.
                    e.Handled = true;
                }
            }
        }

        private void textBoxWide_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ImpostaForm.imposta(textBoxHeight.Text, textBoxWide.Text, 300, 300);
                this.Width = ImpostaForm.larghezza;
                this.Height = ImpostaForm.altezza;

                textBoxWide.Text = Convert.ToString(ImpostaForm.larghezza);
                textBoxHeight.Text = Convert.ToString(ImpostaForm.altezza);
            }
        }

        private void textBoxHeight_KeyDown(object sender, KeyEventArgs e)
        {
            {
                // Initialize the flag to false.

                nonNumberEntered = false;

                // Determine whether the keystroke is a number from the top of the keyboard. 
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    // Determine whether the keystroke is a number from the keypad. 
                    if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    {
                        // Determine whether the keystroke is a backspace. 
                        if (e.KeyCode != Keys.Back)
                        {
                            if (e.KeyCode != Keys.Enter)
                            {
                                // A non-numerical keystroke was pressed. 
                                // Set the flag to true and evaluate in KeyPress event.
                                nonNumberEntered = true;
                            }
                        }
                    }
                }
                //If shift key was pressed, it's not a number. 
                if (Control.ModifierKeys == Keys.Shift)
                {
                    nonNumberEntered = true;
                }
            }

        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Check for the flag being set in the KeyDown event. 
                if (nonNumberEntered == true)
                {

                    string message = "Puoi inserire solo numeri";
                    string caption = "Controllo Numeri Inseriti";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    //Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    DialogResult = DialogResult.OK;

                    //Stop the character from being entered into the control since it is non-numerical.
                    e.Handled = true;
                }
            }
        }

        private void textBoxHeight_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ImpostaForm.imposta(textBoxHeight.Text, textBoxWide.Text, 300, 300);
                this.Width = ImpostaForm.larghezza;
                this.Height = ImpostaForm.altezza;

                textBoxWide.Text = Convert.ToString(ImpostaForm.larghezza);
                textBoxHeight.Text = Convert.ToString(ImpostaForm.altezza);
            }
        }

        private void WINPixel_Resize(object sender, EventArgs e)
        {
            textBoxWide.Text = Convert.ToString(this.Width);
            textBoxHeight.Text = Convert.ToString(this.Height);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
            this.BackColor = Color.Red;
            trackBar1.BackColor = Color.Red;
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.ForeColor = Color.Yellow;
            this.BackColor = Color.Yellow;
            trackBar1.BackColor = Color.Yellow;
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Blue;
            this.BackColor = Color.Blue;
            trackBar1.BackColor = Color.Blue;
            timer1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Green;
            this.BackColor = Color.Green;
            trackBar1.BackColor = Color.Green;
            timer1.Enabled = false;
        }



        private void WINPixel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if  (this.FormBorderStyle == FormBorderStyle.None)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
      
        private void WINPixel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.Width = this.Width - 16;
                this.Height = this.Height - 38;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Width = this.Width + 16;
                this.Height = this.Height + 38;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            OnTimedEvent();
        }



        private void OnTimedEvent()
        {
            valore = valore + 1;
            Console.WriteLine("Valore:   " + valore);
            // Limiti
            if (valore >= 100)
            {
                valore = 0;
            }
        
            /// 1° giro
            if (valore >= 0 & valore < 5)
            {
                this.ForeColor = Color.Red;
                this.BackColor = Color.Red;
                trackBar1.BackColor = Color.Red;
            }

            if (valore >= 6 & valore < 10)
            {
            this.ForeColor = Color.Yellow;
            this.BackColor = Color.Yellow;
            trackBar1.BackColor = Color.Yellow;
            }

            if (valore >= 11 & valore < 20)
            {
                this.ForeColor = Color.Blue;
                this.BackColor = Color.Blue;
                trackBar1.BackColor = Color.Blue;
            }
            if (valore >= 21 & valore <30)
            {
                this.ForeColor = Color.Green;
                this.BackColor = Color.Green;
                trackBar1.BackColor = Color.Green;
            }

            /// 2° giro
            if (valore >=31 & valore <40)
            {
                this.ForeColor = Color.Red;
                this.BackColor = Color.Red;
                trackBar1.BackColor = Color.Red;
            }

            if (valore >=41 & valore < 50)
            {
                this.ForeColor = Color.Yellow;
                this.BackColor = Color.Yellow;
                trackBar1.BackColor = Color.Yellow;
            }

            if (valore >= 51 & valore < 60)
            {
                this.ForeColor = Color.Blue;
                this.BackColor = Color.Blue;
                trackBar1.BackColor = Color.Blue;
            }
            if (valore >= 61 & valore < 70)
            {
                this.ForeColor = Color.Green;
                this.BackColor = Color.Green;
                trackBar1.BackColor = Color.Green;
            }

            /// 3° giro
            /// 
            if (valore >= 81 & valore < 90)
            {
                this.ForeColor = Color.Red;
                this.BackColor = Color.Red;
                trackBar1.BackColor = Color.Red;
            }

            if (valore >= 91 & valore <100)
            {
                this.ForeColor = Color.Yellow;
                this.BackColor = Color.Yellow;
                trackBar1.BackColor = Color.Yellow;
            }

        }

       
    }
}
