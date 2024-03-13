using System.ComponentModel.DataAnnotations;

namespace ViewDatas.Models
{
    public class HomeModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
