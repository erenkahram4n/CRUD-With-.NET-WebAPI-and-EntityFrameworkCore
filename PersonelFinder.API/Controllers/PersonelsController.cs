using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonelFinder.Business.Abstract;
using PersonelFinder.Business.Concrete;
using PersonelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelsController : ControllerBase
    {
        private IPersonelService _personelService;

        public PersonelsController()
        {
            _personelService = new PersonelManager();
        }

        [HttpGet]
        public List<Personel> Get()
        {
            return _personelService.GetAllPersonels();
        }

        [HttpGet("{id}")]
        public Personel Get(int id)
        {
            return _personelService.GetPersonelById(id);
        }

        [HttpPost]
        public Personel Post([FromBody]Personel personel)
        {
            return _personelService.CreatePersonel(personel);
        }
        [HttpPut]
        public Personel Put([FromBody]Personel personel)
        {
            return _personelService.UpdatePersonel(personel);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _personelService.DeletePersonel(id);
        }
    }
}
