using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace EntityFrameworkSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new USER ");
            MyDbContext context = new MyDbContext();

            User u = new User();
            Console.Write("Username: "); 
            u.Username = Console.ReadLine();

            Console.Write("Password: ");
            u.Password = Console.ReadLine();

            context.Users.Update();

            EntityEntry entityEntry = context.Entry(u);
            entityEntry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            context.SaveChanges();

            Console.WriteLine("User saved!!!");
            Console.ReadKey(true);
        }
    }
}
