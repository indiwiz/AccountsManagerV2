using System.ComponentModel.DataAnnotations;

namespace AccountsManager.Web.Models
{
    public class CompanyRegistationModel
    {
        [StringLength(250, ErrorMessage="Name cannot exceed 250 characters")]
        [Required (ErrorMessage="Company Name cannot be blank")]
        [RegularExpression("([a-zA-Z0-9 .&'-]+)", ErrorMessage= "Sprecial characters not allowed")]
        public string CompanyName { get; set; }
    }
}