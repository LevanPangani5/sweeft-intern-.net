using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student_entityFM.DataModels
{
    public class Pupil
    {
        [Key]
        public int PupilID { get; set; }
        [MaxLength(20)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(20)]
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Grade { get; set; }
        [Required]
        public Enums.Gender Gender { get; set; }

        public ICollection<TeacherPupil> Teachers { get; set; }  
    }
}
