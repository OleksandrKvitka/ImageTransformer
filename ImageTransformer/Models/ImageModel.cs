using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImageTransformer.Models
{
    public class ImageModel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("File Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Image")]
        public IFormFile ImageFile { get; set; }
    }
}
