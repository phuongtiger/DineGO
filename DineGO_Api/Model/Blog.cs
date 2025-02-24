using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DineGO_Api.Model
{
    public class Blog
    {
        [Key]
        public int blog_id { get; set; }

        [Required]
        public int res_id { get; set; }

        [Required, MaxLength(150)]
        public string blog_title { get; set; }

        [Required]
        public string blog_information { get; set; }

        public DateTime blog_date { get; set; }

        public string blog_image { get; set; }

        [ForeignKey("res_id")]
        public Restaurant restaurant { get; set; }
    }
}