﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiblaryApp.Models
{
    public class S_Card
    {
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdBook { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int IdLib { get; set; }
        public S_Card()
        {
        }
    }
}
