using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Flipper.Models
{
    public class ProfileCreateViewModel
    {
        [DisplayName("Name")]
        [Required, MaxLength(10)]
        public string ProfileName { get; set; }
    }
}
