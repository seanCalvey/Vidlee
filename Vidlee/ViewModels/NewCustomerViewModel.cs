using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidlee.Models;

namespace Vidlee.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MemberTypes { get; set; }
        public Customer Customer { get; set; }
    }
}