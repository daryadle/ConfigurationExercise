using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConfigurationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("C:\\Users\\gh\\source\\repos\\ConfigurationExercise\\ConfigurationExercise\\jsconfig1.json").Build();
            Setting setting = config.GetRequiredSection("setting").Get<Setting>();
            Console.WriteLine("UserName: "+setting.UserName);
            Console.WriteLine("Password: " + setting.Password);
            Console.ReadKey();
        }
    }
    public class Setting
    {
        public string UserName { get; set; }
        public string Password { get; set; }    
    }
}
