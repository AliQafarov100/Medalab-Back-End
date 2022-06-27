using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedaLab_Back_End.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Fullname { get; set; }
        public string About { get; set; }
        public int? ProfessionId { get; set; }
        public Profession Profession { get; set; }
    }
}
