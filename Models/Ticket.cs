using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNet_Core_6_TicketTracker.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string TicketName { get; set;}

        [Column(TypeName = "nvarchar(1000)")]
        public string TicketDescription { get; set;}

        [Column(TypeName = "nvarchar(100)")]
        public int TicketStatus { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }



    }
}
