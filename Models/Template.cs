using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Models
{
    public class Template
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string TemplateName { get; set; }

     
        [Required]
        public string HtmlContent { get; set; }

        // The type of invoice template.
        public TemplateType TemplateType { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}