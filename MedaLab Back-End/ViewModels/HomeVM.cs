using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedaLab_Back_End.Models;

namespace MedaLab_Back_End.ViewModels
{
    public class HomeVM
    {
        public List<Card> Cards { get; set; }
        public List<ServiceCard> Services { get; set; }
        public List<Profession> Professions { get; set; }
        public List<Gallery> Galleries { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
