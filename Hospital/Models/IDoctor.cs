﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    interface IDoctor
    {
        void Examines();
        void Operates();
    }
}
