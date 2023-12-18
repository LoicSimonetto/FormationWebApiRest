using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleJedi
{
    public class Jedi
    {
        public int PointDeVie { get; set; }
        public void Attaquer(Droide droide)
        {
            if (droide != null)
            {
                droide.PointDeVie -= 30;
            }
        }
    }
}
