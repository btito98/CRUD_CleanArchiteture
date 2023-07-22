using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is Required")]
        [MinLength(1)] 
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "The Discription is Required")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [Range(1, 99999.99)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DisplayName("Price")]
        public decimal Price { get; set; }

    }
}
