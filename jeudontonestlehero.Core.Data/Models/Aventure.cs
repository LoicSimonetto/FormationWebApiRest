using System.ComponentModel.DataAnnotations.Schema;

namespace jeudontonestlehero.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure
    {
        #region Properties
        public int Id { get; set; }
        public string Titre { get; set; }
        #endregion

        #region Constructor
        public Aventure()
        {
            Titre = "";
        }
        #endregion
    }
}
