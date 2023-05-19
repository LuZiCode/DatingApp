using System.ComponentModel.DataAnnotations;
using System.Net.Cache;

namespace BlazorTest100.Models
{
    public interface IEntityInterface
    {

    }
    public class UserProfileEntity : IEntityInterface
    {
        public int? Id { get; set; }
        public string? UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public int? Height { get; set; }
        public string? AboutMe { get; set; }
        public int? CityId { get; set; }
        public int? GenderId { get; set; }
        public int? UsersId { get; set; }

        public int GetAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            return age -1;
        }

    }

    public class UserEntity : IEntityInterface
    {
        public int? Id { get; set; }


        public string? FirstName { get; set; }


        public string? LastName { get; set; }


        public string? Email { get; set; }


        public string? Login { get; set; }


        public string? Password { get; set; }


        public string? Password2 { get; set; }

        public string? Role { get; set; }

        public DateTime? CreateDate { get; set; } = DateTime.Now;


        public DateTime? DeleteDate { get; set; }
    }

    public class UserAndProfileEntity : IEntityInterface
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public int? Age { get; set; }
        public DateTime BirthDate { get; set; }
        public int? Height { get; set; }
        public string? AboutMe { get; set; }
        public int? CityId { get; set; }
        public string? CityName { get; set; }
        public int? GenderId { get; set; }
        public string? GenderName { get; set; }
        public int? UserId { get; set; }
        public string? Elaborate { get; set; }

        public void GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - this.BirthDate.Year;
            Age = age - 1;
        }
    }

    public class LikeEntity : IEntityInterface
    {
        public int? LikerId { get; set; }
        public int? LikeeId { get; set; }
        public int? Status { get; set; }
    }
}
