using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.Models
{
    public class Home
    {
        private PhoneBookDbEntities1 db = new PhoneBookDbEntities1();

        public int count()
        {
            var people = db.People.Count();
            return people;
        }

        public int bdays()
        {
            var people = db.People.Where(p => (p.DateOfBirth.Value.Month == DateTime.Today.Month));
            return people.Count();
        }

        public int Updatepeople()
        {
            var people = db.People.Where(p => (p.UpdateOn.Value.Month == DateTime.Today.Month));
            return people.Count();
        }
    }
}