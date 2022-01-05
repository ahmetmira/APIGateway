using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Model;

namespace Contact.Infrastructre
{
    public interface IContactServices
    {
        public Contacts GetById(int id);
    }
}
