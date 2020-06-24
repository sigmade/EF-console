using System;
using System.Linq;

namespace EF_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF Lesson");
            /*using (AppContext context = new AppContext())
            {
                context.Users.Add(new User() { Name = "Alex", Age = 28 });
                context.SaveChanges();
            }*/
            using (AppContext context = new AppContext())
            {
                var list = context.Users.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Id}-{item.Name}-{item.Age}");
                }
            }
        }
    }
}
