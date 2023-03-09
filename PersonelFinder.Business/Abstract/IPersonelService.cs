using PersonelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelFinder.Business.Abstract
{
    public interface IPersonelService
    {
        List<Personel> GetAllPersonels();

        Personel GetPersonelById(int id);

        Personel CreatePersonel(Personel personel);

        Personel UpdatePersonel(Personel personel);

        void DeletePersonel(int id);
    }
}
