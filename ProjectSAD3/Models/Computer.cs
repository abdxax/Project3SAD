using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace ProjectSAD3.Models
{
    public class Computer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
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
        public  String ImgPath { get; set; }
    }
}
