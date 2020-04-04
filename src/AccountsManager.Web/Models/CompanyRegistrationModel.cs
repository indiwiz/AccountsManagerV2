using System.ComponentModel.DataAnnotations;

namespace AccountsManager.Web.Models
{
    public class CompanyRegistationModel
    {
        [StringLength(250), Required]
        public string CompanyName { get; set; }
    }
}