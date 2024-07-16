using System.ComponentModel.DataAnnotations;

namespace FindCatsMVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public IEnumerable<Models.Cat> Cats { get; set; }

        public User()
        {
            Id = 0;
            Username = "";
            Password = "";
            Email = "";
            Cats = new List<Models.Cat>();
        }

        public User(int id, string username, string password, string email, IEnumerable<Models.Cat> cats)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            Cats = cats;
        }

    }
}
