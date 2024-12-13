using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinası
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizle =true;
        private int _biirnciDeger;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rakam1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else if(ekranLabel.Text=="0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "1";
            }
            else
            {
                ekranLabel.Text += "1";
            }

        }

        private void rakam2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "2";
            }
            else
            {
                ekranLabel.Text += "2";
            }

        }

        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "3";
            }
            else
            {
                ekranLabel.Text += "3";
            }

        }

        private void rakam4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "4";
            }
            else
            {
                ekranLabel.Text += "4";
            }

        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "5";
            }
            else
            {
                ekranLabel.Text += "5";
            }

        }

        private void rakam6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "6";
            }
            else
            {
                ekranLabel.Text += "6";
            }

        }

        private void rakam7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "7";
            }
            else
            {
                ekranLabel.Text += "7";
            }

        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "8";
            }
            else
            {
                ekranLabel.Text += "8";
            }

        }

        private void rakam9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = " ";
                ekranLabel.Text += "9";
            }
            else
            {
                ekranLabel.Text += "9";
            }

        }

        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizle)
            {
                ekranLabel.Text = " ";
                _ekranTemizle = false;
            }
            else 
                ekranLabel.Text += "0";
           

        }

        private void artıButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizle = true;
            _biirnciDeger =Convert.ToInt32( ekranLabel.Text);
        }

        private void çıkarmaButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizle = true;
            _biirnciDeger = Convert.ToInt32(ekranLabel.Text);

        }

        private void çarpmaButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizle = true;
            _biirnciDeger = Convert.ToInt32(ekranLabel.Text);
        }

        private void bölmeButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizle = true;
            _biirnciDeger = Convert.ToInt32(ekranLabel.Text);
        }

        private void eşittirButton_Click(object sender, EventArgs e)
        {
            int ikinciDeger = Convert.ToInt32(ekranLabel.Text);
            int sonuc = 0;


            switch(_islem)
            {
                case '+':
                    sonuc=_biirnciDeger+ikinciDeger; break;
                case '-':
                    sonuc = _biirnciDeger - ikinciDeger; break;
                case '*':
                    sonuc = _biirnciDeger * ikinciDeger; break;
                case '/':
                    sonuc = _biirnciDeger / ikinciDeger; break;




            }


            ekranLabel.Text =sonuc.ToString();

        }

        private void silButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = " ";
            _biirnciDeger = 0;
            
        }
    }
}
