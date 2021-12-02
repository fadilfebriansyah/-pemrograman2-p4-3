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

namespace P4_3_1204029
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Text Box Huruf tidak boleh kosong !");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }
        private void txtAngka_Leave(object sender, EventArgs e)
        {

            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Text Box Angka tidak boleh kosong !");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka, "");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
                }
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Text Box Email tidak boleh kosong !");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epCorrect.SetError(txtEmail, "Betul");
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                }
                else
                {
                    epCorrect.SetError(txtEmail, "");
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "Format email salah ! \nContoh : a@b.c");
                }
            }
        }
        private void Angka1_Leave(object sender, EventArgs e)
        {
            if (Angka2.Text != "")
            {
                if (int.Parse(Angka1.Text) > int.Parse(Angka2.Text))
                {
                    epWrong.SetError(Angka1, "Angka 1 tidak boleh lebih dari Angka 2");
                    epWarning.SetError(Angka1, "");
                    epCorrect.SetError(Angka1, "");
                }
                else
                {
                    epWrong.SetError(Angka1, "");
                    epWarning.SetError(Angka1, "");
                    epCorrect.SetError(Angka1, "Betul!");

                    epWrong.SetError(Angka2, "");
                    epWarning.SetError(Angka2, "");
                    epCorrect.SetError(Angka2, "Betul!");
                }
            }
            else
            {
                epWrong.SetError(Angka2, "");
                epWarning.SetError(Angka2, "Isi Angka 2");
                epCorrect.SetError(Angka2, "");
            }
        }
        private void Angka2_Leave(object sender, EventArgs e)
        {
            if (Angka1.Text != "")
            {
                if (int.Parse(Angka1.Text) > int.Parse(Angka2.Text))
                {
                    epWrong.SetError(Angka1, "");
                    epWarning.SetError(Angka1, "Angka 1 harus kurang dari Angka 2");
                    epCorrect.SetError(Angka1, "");
                }
                else
                {
                    epWrong.SetError(Angka1, "");
                    epWarning.SetError(Angka1, "");
                    epCorrect.SetError(Angka1, "Betul!");
                    epWrong.SetError(Angka2, "");
                    epWarning.SetError(Angka2, "");
                    epCorrect.SetError(Angka2, "Betul!");
                }
            }
            else
            {
                epWrong.SetError(Angka2, "");
                epWarning.SetError(Angka2, "Isi Angka 1");
                epCorrect.SetError(Angka2, "");
            }
        }
    }
}
    