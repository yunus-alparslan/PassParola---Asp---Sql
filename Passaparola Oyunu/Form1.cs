using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Passaparola_Oyunu
{
    public partial class PassParola : Form
    {

        SqlConnection bgln = new SqlConnection("Data Source=DESKTOP-0V73418\\SQLEXPRESS;Initial Catalog=PspPrl;Integrated Security=True");

        public PassParola()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

         
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

 



        }

        private void label6_Click(object sender, EventArgs e)
        {
        
        



        }
        int soru = 0;
        int sorusay = 0;
        int dogru = 0, yanlıs = 0;
        private void button24_Click(object sender, EventArgs e)
        {
            button24.Text = "Sonraki";   
            sorusay++;
            



            if (sorusay == 1)
            {
                button2.BackColor = Color.Yellow;

                bgln.Open();
                SqlCommand trveri = new SqlCommand("Select Sorular From Table_Soru where Soruid=1", bgln);

                SqlDataReader ada = trveri.ExecuteReader();
                while (ada.Read())
                {
                    richTextBox1.Text = ada[0].ToString();
                }
                bgln.Close();

               
            }
            else if (sorusay == 2)
            {
                bgln.Open();
                SqlCommand trveri = new SqlCommand("Select Sorular From Table_Soru where Soruid=6", bgln);

                SqlDataReader ada = trveri.ExecuteReader();
                while (ada.Read())
                {
                    richTextBox1.Text = ada[0].ToString();
                }
                bgln.Close();
                button4.BackColor = Color.Yellow;

            }
            else if (sorusay == 3)
            {
                bgln.Open();
                SqlCommand trveri = new SqlCommand("Select Sorular From Table_Soru where Soruid=7", bgln);

                SqlDataReader ada = trveri.ExecuteReader();
                while (ada.Read())
                {
                    richTextBox1.Text = ada[0].ToString();
                }
                bgln.Close();
                button3.BackColor = Color.Yellow;

            }
            else if (sorusay == 4)
            {

                bgln.Open();
                SqlCommand trveri = new SqlCommand("Select Sorular From Table_Soru where Soruid=8", bgln);

                SqlDataReader ada = trveri.ExecuteReader();
                while (ada.Read())
                {
                    richTextBox1.Text = ada[0].ToString();
                }
                bgln.Close();
                button7.BackColor = Color.Yellow;
            }
            else if (sorusay == 5)
            {

                bgln.Open();
                SqlCommand trveri = new SqlCommand("Select Sorular From Table_Soru where Soruid=9", bgln);

                SqlDataReader ada = trveri.ExecuteReader();
                while (ada.Read())
                {
                    richTextBox1.Text = ada[0].ToString();
                }
                bgln.Close();
                button8.BackColor = Color.Yellow;
            }
            else if (sorusay == 6)
            {

                bgln.Open();
                SqlCommand trveri = new SqlCommand("Select Sorular From Table_Soru where Soruid=10", bgln);

                SqlDataReader ada = trveri.ExecuteReader();
                while (ada.Read())
                {
                    richTextBox1.Text = ada[0].ToString();
                }
                bgln.Close();
                button9.BackColor = Color.Yellow;
            }


           
           
            Text = "Soru : "+sorusay.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (sorusay)
                {
                    case 1:
                        if (textBox1.Text == "Ankara" || textBox1.Text == "ankara")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                            
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "Brezilya" || textBox1.Text == "brezilya")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "Canakkale" || textBox1.Text == "canakkale" || textBox1.Text == "çanakkale" || textBox1.Text == "Çanakkale")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "Derya Kuzusu" || textBox1.Text == "derya kuzusu")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "Edirne" || textBox1.Text == "edirne")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Fatih" || textBox1.Text == "fatih")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                       
                        
                }
            }
        }
    }
}
