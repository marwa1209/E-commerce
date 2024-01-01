using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    internal class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public bool IsAdmin { get; set; }
        public Users()
        {
            this.Id = 0;
            this.Username = "";
            this.Email = "";
            this.Password = "";
            this.Age = 0;
            this.IsAdmin = false;

        }
        public Users(int Id, string Username ,string Email , string Password , int Age , bool IsAdmin)
        {
            this.Id = Id;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.Age = Age;
            this.IsAdmin = IsAdmin;

        }
        //delete
        public Users(int Id)
        {
            this.Id = Id;
        }

    }
   
}
