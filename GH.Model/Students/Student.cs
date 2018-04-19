using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Model.Students
{
    public class Student : Entity
    {
        [Index]
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Index]
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Index]
        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }
    }
}
