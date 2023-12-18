using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Question")]
    public class Question
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        public int ParagrapheId { get; set; }
        
        public List<Reponse> MesReponses { get; set; }
        #endregion
        #region Constructors
        public Question()
        {
            Titre= string.Empty;
            MesReponses = new List<Reponse>();
        }
        #endregion
    }
}
