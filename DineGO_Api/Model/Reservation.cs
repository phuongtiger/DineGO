using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DineGO_Api.Model
{
    public class Reservation
    {
        [Key]
        public int re_id { get; set; }

        [Required]
        public int cus_id { get; set; }

        [Required]
        public int res_id { get; set; }

        public DateTime re_date { get; set; }

        [Range(1, 100)]
        public int re_quantity { get; set; }

        [Required, MaxLength(50)]
        public string re_status { get; set; }

        public string re_note { get; set; }

        [ForeignKey("cus_id")]
        public Customer customer { get; set; }

        [ForeignKey("res_id")]
        public Restaurant restaurant { get; set; }

        public ICollection<Notification> notifications { get; set; } = new List<Notification>();
    }
}