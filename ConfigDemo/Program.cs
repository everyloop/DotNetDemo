using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConfigDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("MyProject_Environment")}.json", optional: true)
                .AddUserSecrets("2a050483-5045-4a5c-9c38-247b2f1c0f18")
                .Build();

            Console.WriteLine($"Name: {config["Name"]}");

            var info = config.GetSection("ContactInfo");

            Console.WriteLine($"Email: {info["Email"]}");

            Console.WriteLine($"Connection string: {config.GetConnectionString("default")}");
        }
    }
}
