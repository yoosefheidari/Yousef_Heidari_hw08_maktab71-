using System.ComponentModel.DataAnnotations;

namespace Yousef_Heidari_hw08_maktab71.Models
{
    public class Person
    {
        [Display(Name="ID")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
