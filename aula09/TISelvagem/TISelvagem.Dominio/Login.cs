﻿

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TISelvagem.Dominio
{
        public class Login
    {

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Senha")]
 
        public string Senha { get; set; }

       
    }
}
