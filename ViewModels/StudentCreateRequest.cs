using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels;

public class StudentCreateRequest
{
    [DisplayName("First Name")]
    public string? FirstName { get; set; }

    [DisplayName("Last Name")]
    public string? LastName { get; set; }
    [DisplayName("Date of Birth")]
    public DateTime DateOfBirth { get; set; }
    [DisplayName("Email")]
    public string Email { get; set; }
    [DisplayName("Profile Image")]
    public string ProfileImage { get; set; }
}