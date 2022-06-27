using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedaLab_Back_End.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
