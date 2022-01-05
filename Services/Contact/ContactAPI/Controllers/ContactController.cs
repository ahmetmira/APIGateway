using Contact.Infrastructre;
using Contact.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactServices contactServices;

        public ContactController(IContactServices ContactServices)
        {
            contactServices = ContactServices;
        }

        [HttpGet("{id}")]
        public Contacts GetContactsById(int id) => contactServices.GetById(id);
    }
}
