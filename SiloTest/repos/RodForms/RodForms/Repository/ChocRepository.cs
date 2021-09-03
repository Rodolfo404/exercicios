using RodForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RodForms.Repository
{
    public class ChocRepository
    {
        private static List<Choc> listaChoc = new List<Choc>();
        public void Salvar(Choc model)
        {
            listaChoc.Add(model);
        }
        public void Editar(Choc model)
        {
            Choc modelAntigo = listaChoc.Find(d => d.Id == model.Id);
            if(modelAntigo != null)
            {
                modelAntigo = model;
            }
        }
        public void Deletar(int id)
        {
            Choc model = listaChoc.Find(d => d.Id == id);
            if (model != null)
            {
                listaChoc.Remove(model);
            }

        }
        public List<Choc> Listar()
        {
            return listaChoc;
        }
    }
}