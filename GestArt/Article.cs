using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestArt
{
    public class Article
    {
    
        public string Libelle { get; set; }
        public double Pu { get; set; }
        public Article()
        {

        }

        public Article(string lib, double prix)
        {
            this.Libelle = lib;
            this.Pu = prix;
        }
    }
}
