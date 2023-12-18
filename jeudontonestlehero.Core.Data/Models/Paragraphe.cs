using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        [Range(1,9999, ErrorMessage = "Le numéro doit être compris entre 1 et 9999.")]
        [Required(ErrorMessage = "Le numéro est requis.")]
        public int Numero { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigné.")]
        public string Titre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "La description est requise.")]
        public string Description { get; set; }
        public Question MaQuestion { get; set; }
        #endregion
        #region Constructors
        public Paragraphe()
        {
            Titre = string.Empty;
            Description = string.Empty;
            MaQuestion= new Question();
        }
        #endregion
    }
}
