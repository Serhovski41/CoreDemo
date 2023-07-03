using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class RoleViewModel
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen rol adı giriniz")]
        public string name { get; set; }
    }
}
