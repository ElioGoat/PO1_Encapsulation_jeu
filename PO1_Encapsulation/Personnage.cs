using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        int pointDeVie;
        int attaque;

        public int PointDeVie {
            get
            {
                return pointDeVie;
            }
            set
            {
                if (value <= 0)
                {
                    
                }
            } 
        }

        public int Attaque { get => attaque; set => attaque = value; }
    }
}
