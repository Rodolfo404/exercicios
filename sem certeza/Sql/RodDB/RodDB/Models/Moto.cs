using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RodDB.Models
{
    public class Moto
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public decimal Valor { get; set; }
    }
}