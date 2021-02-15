﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCRUMAssignment.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string ImgPath { get; set; }
        public string KategoriNavn { get; set; }
        public List<Emne> Emner { get; set; }
    }
}