using System;
using System.Collections.Generic;
using System.Text;
using PIM.Notebooks;
using PIM.Tablets;
using PIM.Projetores;

namespace PIM.Equipamentos
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Voltagem { get; set; }
        public int CodigoSerie { get; set; }
        public bool Alugado { get; set; }
    }
}

