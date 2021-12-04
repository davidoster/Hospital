using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    abstract class Human: IHuman
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _mobileTelephone;

        public string MobileTelephone
        {
            get { return _mobileTelephone; }
            set { _mobileTelephone = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Human()
        {

        }

        public Human(string _firstName, string _lastName, string _mobileTelephone, string _email)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.MobileTelephone = _mobileTelephone;
            this.Email = _email;
        }

        public override string ToString()
        {
            return $"{Id} {_firstName} {_lastName} {_mobileTelephone} {_email}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public abstract void Talks();

        public abstract void Sleeps();

        public abstract void Runs();
    }
}
