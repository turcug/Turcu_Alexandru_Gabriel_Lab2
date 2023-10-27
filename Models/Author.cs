using System.ComponentModel.DataAnnotations;

namespace Turcu_Alexandru_Gabriel_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Display(Name = "Author's Name")]
        public string FullName => FirstName + " " + LastName;
        public ICollection<Book>? Books { get; set; }
    }
}
