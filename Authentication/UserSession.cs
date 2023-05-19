using System.ComponentModel.DataAnnotations;

namespace BlazorTest100.Authentication
{
    public class UserSession
    {
        public int? Id { get; set; }
        public string? UserName { get; set;}
        public string? Role { get; set; }

        public string? FirstName { get; set; }


        public string? LastName { get; set; }


        public string? Email { get; set; }


        public DateTime? CreateDate { get; set; }


        public DateTime? DeleteDate { get; set; }


    }
}
