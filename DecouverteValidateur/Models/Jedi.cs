using System.ComponentModel.DataAnnotations;

namespace DecouverteValidateur.Models
{
    public class Jedi
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le nom doir être renseigné !")]
        public string Name { get; set; }
        [Range(1,300,ErrorMessage = "La taille doit être comprise entre 1 et 300 !")]
        public int Size { get; set; }
    }
}
