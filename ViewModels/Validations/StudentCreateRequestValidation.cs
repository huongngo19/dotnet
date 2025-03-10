using FluentValidation;
using StudentManagement.Data.Entities;

namespace StudentManagement.ViewModels.Validations
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(student => student.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(student => student.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(student => student.Email).EmailAddress().WithMessage("Invalid email address.");
            RuleFor(student => student.DateOfBirth).LessThan(DateTime.Now).WithMessage("Date of birth must be in the past.");
        }
    }
}
