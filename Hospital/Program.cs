using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {

            // Hospital
            // Admissions [Patient, Long/Short Stay, [[EXR], [Doctors]], [[ER], [Doctors]]]
            // Emergency Room(ER) [Doctors] (surgical operation)
            // Examination Rooms(EXR) [Doctors] (examination)
            // Patients, Long Stay, Short Stay <--- ER, EXR
            // Every Patient has a number of doctors from ER and/or EXR
            // A Doctor can be both on ER and on EXR

            Hospital.Models.Human h = new Models.Doctor("George","Pasparakis", "6977649229", "paspa@hotmail.com","Surgeon");
            Hospital.Models.Doctor d = new Models.Doctor("George", "Pasparakis", "6977649229", "paspa@hotmail.com", "Surgeon");
            var d1 = (h as Hospital.Models.Doctor);
            Console.WriteLine(h);
            
        }
    }
}
