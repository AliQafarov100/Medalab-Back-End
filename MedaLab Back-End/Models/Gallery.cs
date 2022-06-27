using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MedaLab_Back_End.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [NotMapped]

        public IFormFile Photo { get; set; }
    }
}
