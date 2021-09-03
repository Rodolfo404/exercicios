using RodDB.Context;
using RodDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RodDB.Repository
{
    public class MotoRepository
    {
        public void Create(Moto model)
        {
            using (var context = new MotoContext())
            {
                context.Motos.Add(model);
                context.SaveChanges();
            }
        }

        public List<Moto> Read()
        {
            List<Moto> Moto = new List<Moto>();
            using (var context = new MotoContext())
            {
                Moto = context.Motos.ToList();
            }
            return Moto;
        }
        public Moto Read(int id)
        {
            Moto model = new Moto();
            using (var context = new MotoContext())
            {
                model = context.Motos.Find(id);
            }
            return model;
        }
        public void Update(Moto model)
        {
            using (var context = new MotoContext())
            {
                context.Entry<Moto>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void Delete(int id)
        {
            using (var context = new MotoContext())
            {
                context.Entry<Moto>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
        }
    }
}