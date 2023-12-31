﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UniSys.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Account class
public class Account : IdentityUser
{
    public string Name { get; set; }
    public int Registration { get; set; }
    public string Course { get; set; }
    public string ImagePath { get; set; }
    public string Period { get; set; }
}