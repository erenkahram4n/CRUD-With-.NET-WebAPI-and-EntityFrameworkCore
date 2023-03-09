using PersonelFinder.Business.Abstract;
using PersonelFinder.DataAccess.Abstract;
using PersonelFinder.DataAccess.Concrete;
using PersonelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelFinder.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private IPersonelRepository _personelRepository;

        public PersonelManager()
        {
            _personelRepository = new PersonelRepository();
        }

        public Personel CreatePersonel(Personel personel)
        {
            return _personelRepository.CreatePersonel(personel);
        }

        public void DeletePersonel(int id)
        {
            _personelRepository.DeletePersonel(id);
        }

        public List<Personel> GetAllPersonels()
        {
            return _personelRepository.GetAllPersonels();
        }

        public Personel GetPersonelById(int id)
        {
            if (id > 0)
            {
                return _personelRepository.GetPersonelById(id);
            }
            throw new Exception("id 1'den küçük olamaz");
        }

        public Personel UpdatePersonel(Personel personel)
        {
            return _personelRepository.UpdatePersonel(personel);
        }
    }
}
