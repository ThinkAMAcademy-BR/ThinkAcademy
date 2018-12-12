using System.ComponentModel.DataAnnotations;

namespace ThinkAM.ThinkAcademy.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}