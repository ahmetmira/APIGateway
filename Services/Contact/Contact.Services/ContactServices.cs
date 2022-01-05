using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Infrastructre;
using Contact.Model;

namespace Contact.Services
{
    public class ContactServices : IContactServices
    {
        public Contacts GetById(int id)
        {
            return new Contacts()
            {
                Contact_Id = new Random().Next(1000),
                FirstName = "Ahmet",
                LastName = "MİRA"
            };
        }
    }
}
