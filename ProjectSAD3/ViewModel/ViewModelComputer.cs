using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSAD3.ViewModel
{
    public class ViewModelComputer
    {
       
        [Required]
        public String Company { get; set; }
        [Required]
        public String Models { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public String price { get; set; }
        [Required]
        public int Count { get; set; }

        public String status { get; set; }
        public IFormFile ImgPath { get; set; }
    }
}
