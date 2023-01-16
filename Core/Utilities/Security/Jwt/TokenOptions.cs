﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        public string Audience { get; set; }//Token gebruikers
        public string Issuer { get; set; }//Handtekening
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
