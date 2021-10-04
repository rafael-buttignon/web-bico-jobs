﻿using Fatec.Domain.Entities.Address;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ProjectFatec.WebApi.Models.Request
{
    public class UserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string CPF { get; set; }
        public AddressRequest Address { get; set; }
    }
}


