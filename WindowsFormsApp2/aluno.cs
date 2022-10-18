using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class aluno
    {
        public string rm;
        public string nome;
        public int n1;
        public int n2;
        public int n3;
        public int n4;
        public double media;

        public double calcmendia()
        {
            this.media= this.n1 + this.n2 + this.n3 + this.n4 ;
            return media;
        }
    }
}
