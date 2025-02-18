using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
            private int pointDeVie;
            private int puissanceAttaque;
            private int pointDeVieMaximal;

        public int PointDeVie { get => pointDeVie;
            set
            {
                if (value < 0)
                {
                    pointDeVie = 0;
                }
                else if (value > PointDeVieMaximal)
                {
                    pointDeVie = PointDeVieMaximal;
                }
                else
                {
                    pointDeVie = value;
                }
            }
        }
        public int PuissanceAttaque { get => puissanceAttaque; set => puissanceAttaque = value; }

        public bool EstMort
        {
            get
            {
                if (pointDeVie == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int PointDeVieMaximal { get => pointDeVieMaximal; set => pointDeVieMaximal = value; }
    }
}
