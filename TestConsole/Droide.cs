using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    [Table("Droide")]
    public class Droide
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        //public Arme Arme { get; set; }
        
        public Droide()
        {
            Matricule= string.Empty;
            //Arme = new Arme();
        }
    }
}
