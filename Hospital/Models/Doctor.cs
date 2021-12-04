using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    class Doctor: Human, IDoctor
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

        public override string ToString()
        {
            return base.ToString() + $" {Specialty}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Talks()
        {
            throw new NotImplementedException();
        }

        public override void Sleeps()
        {
            throw new NotImplementedException();
        }

        public override void Runs()
        {
            throw new NotImplementedException();
        }

        public void Examines()
        {
            throw new NotImplementedException();
        }

        public void Operates()
        {
            throw new NotImplementedException();
        }
    }
}
