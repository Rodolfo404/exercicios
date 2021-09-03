using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC
{
    public class SkateRepository
    {
        public static List<Skate> repositorio = new List<Skate>();
        
        public SkateRepository()
        {

            repositorio = new List<Skate>();
        }

        public void Salvar(Skate model)
        {
            repositorio.Add(model);
        }
        public List<Skate> Tabela()
        {
            return repositorio;
        }

    }
}