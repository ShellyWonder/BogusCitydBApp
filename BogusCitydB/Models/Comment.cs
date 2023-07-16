using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Net.Sockets;
using BogusCitydB.Data.Models;

namespace BogusCitydB.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int CEUClassId { get; set; }

        [DisplayName("Comment")]
        [StringLength(2000)]
        public string? Comments { get; set; }

        [DataType(DataType.Date)]

        [DisplayName("Date")]
        public DateTimeOffset CreatedDate { get; set; }

        public int TicketId { get; set; }

        public string? UserId { get; set; }

        //Nav properties
        [DisplayName("CEU Class")]
        public virtual CEUClass? CEUClass { get; set; }

        public virtual CEUser? User { get; set; }   
    }
}
