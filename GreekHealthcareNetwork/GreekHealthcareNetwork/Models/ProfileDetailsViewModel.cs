﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreekHealthcareNetwork.Models
{
    public class ProfileDetailsViewModel
    {
        public ApplicationUser User { get; set; }
        public Doctor Doctor { get; set; }
        public Insured Insured { get; set; }
        public HttpPostedFileBase ProfilePicture { get; set; }
    }
}