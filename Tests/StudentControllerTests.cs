// using Xunit;
// using StudentManagement.Controllers;
// using StudentManagement.Entities;
// using Microsoft.AspNetCore.Mvc;

// namespace StudentManagement.Tests
// {
//     public class StudentControllerTests
//     {
//         [Fact]
//         public void GetAllStudents_ReturnsOkResult()
//         {
//             // Arrange
//             var controller = new StudentController();

//             // Act
//             var result = controller.GetAllStudents();

//             // Assert
//             Assert.IsType<OkObjectResult>(result);
//         }

//         [Fact]
//         public void GetStudentById_ReturnsNotFoundResult()
//         {
//             // Arrange
//             var controller = new StudentController();

//             // Act
//             var result = controller.GetStudentById(0);

//             // Assert
//             Assert.IsType<NotFoundResult>(result);
//         }

//         [Fact]
//         public void CreateStudent_ReturnsBadRequestResult()
//         {
//             // Arrange
//             var controller = new StudentController();
//             var student = new Student();

//             // Act
//             var result = controller.CreateStudent(student);

//             // Assert
//             Assert.IsType<BadRequestObjectResult>(result);
//         }
//     }
// }
