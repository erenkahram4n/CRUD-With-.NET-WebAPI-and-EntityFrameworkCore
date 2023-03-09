using PersonelFinder.DataAccess.Abstract;
using PersonelFinder.DataAccess;
using PersonelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PersonelFinder.DataAccess.Concrete
{
    public class PersonelRepository : IPersonelRepository
    {
        public Personel CreatePersonel(Personel personel)
        {
            using (var personelDbContext = new PersonelDbContext())
            {
                personelDbContext.Personeller.Add(personel);
                personelDbContext.SaveChanges();
                return personel;
            }
        }

        public void DeletePersonel(int id)
        {
            using (var personelDbContext = new PersonelDbContext())
            {
                var deletedPersonel = GetPersonelById(id);
                personelDbContext.Personeller.Remove(deletedPersonel);
                personelDbContext.SaveChanges();
            }
        }

        public List<Personel> GetAllPersonels()
        {
            using (var personelDbContext = new PersonelDbContext())
            {
                return personelDbContext.Personeller.ToList();
            }
        }

        public Personel GetPersonelById(int id)
        {
            using (var personelDbContext = new PersonelDbContext())
            {
                return personelDbContext.Personeller.Find(id);
            }
        }

        public Personel UpdatePersonel(Personel personel)
        {
            using (var personelDbContext = new PersonelDbContext())
            {
                personelDbContext.Personeller.Update(personel);
                personelDbContext.SaveChanges();
                return personel;
            }
        }
    }
}
