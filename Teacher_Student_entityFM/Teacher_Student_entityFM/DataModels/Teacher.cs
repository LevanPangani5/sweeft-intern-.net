using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student_entityFM.DataModels
{
    public class Teacher
    {
        [Key]
        
        public int TeacherID { get; set; }
        [MaxLength(20)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(20)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(30)]
        [Required]
        public string Topic { get; set; }
        [Required]
        public Enums.Gender Gender { get; set; }

        public ICollection<TeacherPupil> Pupils { get; set; }
    }
}
