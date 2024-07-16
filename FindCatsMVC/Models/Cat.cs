using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace FindCatsMVC.Models
{
    public class Cat
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public IEnumerable<Models.User> Owners { get; set; }
        public string ImagePath { get; set; }

        public Cat()
        {
            ID = 0;
            Name = "";
            Breed = "";
            Color = "";
            Age = 0;
            Owners = new List<Models.User>();
            ImagePath = "";
        }

        public Cat(int id, string name, string breed, string color, int age, IEnumerable<Models.User> owners, string imagePath)
        {
            ID = id;
            Name = name;
            Breed = breed;
            Color = color;
            Age = age;
            Owners = owners;
            ImagePath = imagePath;
        }
    }
}
