using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAtrio
{
    [Table("Personne")]
    public class Personne
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        [NotMapped]
        public int Age
        {
            get
            {
                return (int)(DateTime.Now - BirthDate).TotalDays / 365;
            }
        }
    }
}