﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Entities
{
    public class Medico : Usuario
    {       
        public int CRM { get; set; }
        public string Especialidade { get; set; }

    }
}
