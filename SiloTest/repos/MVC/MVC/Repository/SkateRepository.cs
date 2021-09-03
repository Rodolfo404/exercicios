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
        public List<Skate> Read()
        {
            return repositorio;
        }
        public Skate Read(int id)
        {
            return repositorio.Find(s => s.Id == id);
        }

        public void Delete(int id)
        {
            Skate model = Read(id);
            if (model != null)
            {
                repositorio.Remove(model);

            }
        }

        public void Editar(Skate model)
        {
            int index = repositorio.FindIndex(s => s.Id == model.Id);
            repositorio[index] = model;
        }
    }
}