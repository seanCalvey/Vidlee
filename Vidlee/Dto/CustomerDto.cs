﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidlee.Models;

namespace Vidlee.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewletter { get; set; }

        public byte MembershipTypeId { get; set; }


      //  [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }
    }
}