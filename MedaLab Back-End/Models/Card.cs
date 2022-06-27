﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedaLab_Back_End.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Icon { get; set; }
        public bool IsMain { get; set; }
    }
}
