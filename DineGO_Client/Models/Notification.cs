using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DineGO_Client.Model
{
    public class Notification
    {
        [Key]
        public int noti_id { get; set; }

        [Required]
        public int cus_id { get; set; }

        [Required]
        public int re_id { get; set; }

        [Required, StringLength(100)]
        public string noti_title { get; set; }

        [Required]
        public string noti_content { get; set; }

        [Required, StringLength(50)]
        public string noti_type { get; set; }

        [Required]
        public DateTime noti_date { get; set; }

        [Required]
        public bool noti_status { get; set; }

        [ForeignKey("cus_id")]
        public virtual Customer customer { get; set; }

        [ForeignKey("re_id")]
        public virtual Reservation reservation { get; set; }
    }
}