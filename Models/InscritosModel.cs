﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLive.Models
{
    public class InscritosModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string EnderecoInstagram { get; set; }
        public bool? Excluido { get; set; }
    }
}
