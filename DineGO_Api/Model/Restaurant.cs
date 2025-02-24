using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DineGO_Api.Model
{
    public class Restaurant
    {
        [Key]
        public int res_id { get; set; }

        [Required, MaxLength(50)]
        public string res_username { get; set; }

        [Required, MaxLength(100)]
        public string res_password { get; set; }

        [Required, MaxLength(100)]
        public string res_name { get; set; }

        [Required, MaxLength(50)]
        public string res_type { get; set; }

        [MaxLength(200)]
        public string res_address { get; set; }

        [Phone]
        public string res_phone { get; set; }

        public string res_information { get; set; }

        public decimal res_rate { get; set; }

        public decimal res_price { get; set; }

        public decimal res_discount { get; set; }

        public string res_image { get; set; }

        [Required]
        public int cate_id { get; set; } 

        [ForeignKey("cate_id")]
        public virtual Category category { get; set; }
    }
}