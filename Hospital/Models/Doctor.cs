using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    class Doctor: Human
    {
        //[Key]
        private string _specialty;

        public string Specialty
        {
            get { return _specialty; }
            set { _specialty = value; }
        }

        public Doctor()
        {

        }

        public Doctor(string firstName, string lastName, string mobileTelephone, string email, string specialty) :
            base(firstName, lastName, mobileTelephone, email)
        {
            this.Specialty = specialty;
        }
    }
}
