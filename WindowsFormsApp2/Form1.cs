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
            Aluno.n1 = Convert.ToInt32(txtn1.Text);
            Aluno.n2 = Convert.ToInt32(txtn2.Text);
            Aluno.n3 = Convert.ToInt32(txtn3.Text);
            Aluno.n4 = Convert.ToInt32(txtn4.Text);

            Aluno.calcmendia();
            Aluno.Defsituacao();


            bool clone = false;
            foreach (aluno p in lista)
            {
                if (p.rm == Aluno.rm)
                {
                    clone = true;
                }
            }
            if (!clone)
            {
      

                lista.Add(Aluno);
                MessageBox.Show("cadastro feito");
                DataGridView.Rows.Add(Aluno.nome, Aluno.n1, Aluno.n2, Aluno.n3, Aluno.n4, Aluno.media, Aluno.situ);
                txtnome.Clear();
                txtRM.Clear();
                txtn1.Clear();
                txtn2.Clear();
                txtn3.Clear();
                txtn4.Clear();
            }    
            else
            {
                MessageBox.Show("codigo ja existente");
                txtnome.Clear();
                txtRM.Clear();
                txtn1.Clear();
                txtn2.Clear();
                txtn3.Clear();
                txtn4.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Btndelet_Click(object sender, EventArgs e)
        {
            aluno Aluno = new aluno();
            Aluno.rm = txtRM.Text;
            if (Aluno.rm == txtRM.Text)
            {
                lista.Clear();
            }
        }
    }
}
