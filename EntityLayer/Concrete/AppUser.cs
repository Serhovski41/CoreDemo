using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser: IdentityUser
    {
        public string nameSurname { get; set; }
        public string ImageUrl { get; set; }
    }
}
