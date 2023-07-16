using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using BogusCitydB.Data.Models;
using static BogusCitydB.Extensions.Extensions;

namespace BogusCitydB.Models
{
    public class CEUClassAttachment
    {
        public int Id { get; set; }

        public int CEUClassId { get; set; }

        public string? FileName { get; set; }

        [DisplayName("File Description")]
        [StringLength(500)]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Added")]

        public DateTimeOffset CreatedDate { get; set; }

        [NotMapped]
        [DisplayName("Select a file")]
        [DataType(DataType.Upload)]
        [MaxFileSize(1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".doc", ".docx", ".xls", ".xlsx", ".pdf" })]
        public IFormFile? ImageFormFile { get; set; }

        public string? ImageFileName { get; set; }

        public byte[]? ImageFileData { get; set; }

        [Required]
        [DisplayName("User")]
        public string? UserId { get; set; }

        
        [Display(Name = "File Extension")]
        public string? ImageContentType { get; set; }

        public virtual CEUClass? CEUClass { get; set; }

        public virtual CEUser? User { get; set; }
    }
}
