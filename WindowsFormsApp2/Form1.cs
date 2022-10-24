using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<aluno> lista = new List<aluno>();

        private void Btnexe_Click(object sender, EventArgs e)
        {
     
            aluno Aluno = new aluno();
            Aluno.nome = txtnome.Text;
            Aluno.rm = txtRM.Text;
            Aluno.n1 = Convert.ToInt32(txtn1.Text);
            Aluno.n2 = Convert.ToInt32(txtn2.Text);
            Aluno.n3 = Convert.ToInt32(txtn3.Text); 
            Aluno.n4 = Convert.ToInt32(txtn4.Text);

            Aluno.calcmendia();


            bool clone = false;
            foreach (aluno p in lista)
            {
                if (p.nome ==Aluno.rm)
                {
                    clone = true;
                }
            }
            if (!clone)
            {
            txt1.Text = Aluno.nome;
            txt2.Text = Aluno.rm;
            txt3.Text = txtn1.Text; 
            txt4.Text = txtn2.Text; 
            txt5.Text = txtn3.Text; 
            txt6.Text = txtn4.Text;
            txtmedia.Text = Convert.ToString(Aluno.media);
                lista.Add(Aluno);
                MessageBox.Show("cadastro feito");
            }
            else
            {
                MessageBox.Show("codigo ja existente");
                txtnome.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
