using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox2.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            if (radioButton1.Checked)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("INF.02");
                comboBox2.Items.Add("INF.03");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedItem == "INF.02")
            {
                label13.Text = "Administracja i eksploatacja systemów komputerowych, urządzeń\r\nperyferyjnych i lokalnych sieci komputerowych";
            }

            else if (comboBox2.SelectedItem == "INF.03")
            {
                label13.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych";
            }

            else
            {
                label13.Text = "Projektowanie, programowanie i testowanie aplikacji";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("styczeń");
            comboBox1.Items.Add("czerwiec");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            if (radioButton2.Checked)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("INF.03");
                comboBox2.Items.Add("INF.04");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sprawdzenie = 0;
            
          
        
            var Regex1 = new Regex(@"[A-Z][0-9]+\/");
            if (Regex1.IsMatch(tbb2.Text))
            {
                sprawdzenie = 0;
            }
            else {
                sprawdzenie = 1;
            }

            //Nazwisko
            if (tb1.Text == "")
            {
                tb1.BackColor = Color.Red;
                sprawdzenie = 1;
            }
            else { 
                tb1.BackColor = Color.White;
            }

            //Imie
            if (tb2.Text == "")
            {
                tb2.BackColor = Color.Red;
                sprawdzenie = 1;
            }
            else { 
                tb2.BackColor = Color.White;
            }

            //Data
            if (tb3.Text == "")
            {
                tb3.BackColor = Color.Red;
            }
            else {
                tb3.BackColor = Color.White;
                sprawdzenie = 1;
            }

            //Miejscowosc
            if (tb4.Text == "")
            {
                tb4.BackColor = Color.Red;
                sprawdzenie = 1;
            }
            else { tb4.BackColor = Color.White; }

            //Pesel
            if (tb2.Text == "")
            {
                tb5.BackColor = Color.Red;
                sprawdzenie = 1;
            }
            else
            {
                if (tb2.Text.EndsWith("A"))
                {
                    string Pesel = tb5.Text.ToString();
                    char ostatnia_cyfra = Pesel[Pesel.Length - 1];
                    if (ostatnia_cyfra % 2 == 0)
                    {
                        tb5.BackColor = Color.White;
                    }
                    else
                    {
                        tb5.BackColor = Color.Red;
                        sprawdzenie = 1;
                    }
                }
                else
                {
                    string Pesel = tb5.Text.ToString();
                    char ostatnia_cyfra = Pesel[Pesel.Length - 1];
                    if (ostatnia_cyfra % 2 != 0)
                    {
                        tb5.BackColor = Color.White;
                    }
                    else
                    {
                        tb5.BackColor = Color.Red;
                        sprawdzenie = 1;
                    }
                }
            }

            //Miejscowosc 2
            if (tbb1.Text == "")
            {
                tbb1.BackColor = Color.Red;
                sprawdzenie = 1;
            }
            else
            {
                tbb1.BackColor = Color.White;
            }

            //Ulica i numer domu
            if (tbb2.Text == "")
            {
                tbb2.BackColor = Color.Red;
                sprawdzenie = 1;
            }
            else
            {
                tbb2.BackColor= Color.White;
            }

            //Kod pocztowy
            tbb3.BackColor = Color.Red;
            var post_num = new Regex(@"[0-9]{2}\-[0-9]{3}");
            if (post_num.IsMatch(tbb3.Text))
            {
                tbb3.BackColor = Color.White;
            }
            

            //Poczta
            if(tbb4.Text == "")
            {
                tbb4.BackColor = Color.Red;
                sprawdzenie = 1;
            }
            else
            {
                tbb4.BackColor = Color.White;
            }
            //Telefon
            if (tbb5.Text == "")
            {
                tbb5.BackColor = Color.Red;
                sprawdzenie = 1;
            }
            else
            {
                string phno = tbb5.Text.ToString();
                if (phno.Length >= 9)
                {
                    var nmb = new Regex(@"[0-9]{2}\s[0-9]{2}\s[0-9]{3}");

                    if (nmb.IsMatch(phno))
                    {
                        tbb5.BackColor = Color.White;
                    }
                    else if (phno.StartsWith("+")) {
                        var nmb2 = new Regex(@"[0-9]\s[0-9]{3}\s[0-9]{3}\s[0-9]{3}");
                        if (nmb2.IsMatch(phno))
                        {
                            tbb5.BackColor = Color.White;
                        }
                    }
                }
                else if(phno.StartsWith("+"))
                {
                    MessageBox.Show("Numer niezgodny ze standardem +CC Mobile");
                    sprawdzenie = 1;
                }
                else
                {
                    MessageBox.Show("Numer niezgodny ze standardem +CC AC PHONE");
                    sprawdzenie = 1;
                }
            }


            if (sprawdzenie == 1)
            {
                MessageBox.Show("Wypełnij pola na czerwono");
            }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                richTextBox1.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                richTextBox1.Enabled = true;
            }
        }
    }
}
