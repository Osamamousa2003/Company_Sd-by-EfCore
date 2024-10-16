
using ConsoleApp4.Data;
using ConsoleApp4.Entities;

using Microsoft.Identity.Client;
using System.Text.Json.Serialization;



namespace ConsoleApp4
{

    class Program
    {
        public static void Main(string[] args)
        {

            using (var context = new AppDbContext())
            {
                DataSeeder.Seed(context);
                context.SaveChanges();
            }
        }

      }

 

  }