﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogicLayer.Models
{
    public class UserProfileModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
    }
}
