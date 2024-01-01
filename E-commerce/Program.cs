using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace E_commerce

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read json file

            string usersFile = File.ReadAllText("usersFile.json");
            List<Users> usersList = JsonConvert.DeserializeObject<List<Users>>(usersFile);
            Console.WriteLine("Users List:");

            if (usersList == null)
            {
                usersList = new List<Users>();
            }
            string input = "";
            int Id = 0;
            string Username = "";
            string Email = "";
            string Password = "";
            int Age = 0;
            bool IsAdmin = false;

            while (input != "q")
            {
                Console.WriteLine("enter 'a' to add new user");
                Console.WriteLine("enter 'd' to delete  user");
                Console.WriteLine("enter 's' to show  user");
                Console.WriteLine("enter 'q' to quit ");

                input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        Console.WriteLine("add new user");
                        Console.WriteLine("enter id");
                        Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter username");
                        Username = Console.ReadLine();
                        Console.WriteLine("enter email");
                        Email = Console.ReadLine();
                        Console.WriteLine("enter password");
                        Password = Console.ReadLine();
                        Console.WriteLine("enter age");
                        Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter role");
                        IsAdmin = bool.Parse(Console.ReadLine());
                        usersList.Add(new Users(Id, Username, Email, Password, Age, IsAdmin));
                        String data = JsonConvert.SerializeObject(usersList);
                        File.WriteAllText("usersFile.json", data);
                       
                        break;
                    case "d":
                        
                        Console.WriteLine("enter user id to delete");
                        Id = int.Parse(Console.ReadLine());
                        Users userToDelete = usersList.Find(u => u.Id == Id);
                        usersList.Remove(userToDelete);
                        Console.WriteLine($"User {userToDelete.Id} deleted.");
                        String datadeleted = JsonConvert.SerializeObject(usersList);
                        File.WriteAllText("usersFile.json", datadeleted);
                        Console.WriteLine($"deleted user with id {Id} ");

                        break;
                    case "q":
                        Console.WriteLine("quit program");
                        break;
                    case "s":
                        Console.WriteLine("show my list");
                        foreach (var item in usersList)
                        {
                            Console.WriteLine($"user id = {item.Id}  user name = {item.Username}  user email = {item.Email}  user passwor = {item.Password} user age = {item.Age} is user admin ? {item.IsAdmin}");
                        }
                        break;
                    default:
                        Console.WriteLine("in correct command");
                        break;
                }
            }
            Console.WriteLine("save json data");
            String data2 = JsonConvert.SerializeObject(usersList);
            File.WriteAllText("usersFile.json", data2);
            Console.ReadLine();

        }
    }
}
