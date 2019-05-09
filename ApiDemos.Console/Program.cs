using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ApiDemos.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            //string html = client.GetStringAsync("http://localhost:51237/home/pending").Result;
            //System.Console.WriteLine(html);
            //for (int i = 1; i <= 50; i++)
            //{
            //    var formContent = new FormUrlEncodedContent(new[]
            //    {
            //        new KeyValuePair<string, string>("firstname", Faker.Name.First()),
            //        new KeyValuePair<string, string>("lastname", Faker.Name.Last()),
            //        new KeyValuePair<string, string>("email", Faker.Internet.Email()),
            //        new KeyValuePair<string, string>("phonenumber", Faker.Phone.Number()),
            //        new KeyValuePair<string, string>("notes", Faker.Lorem.Paragraph()),
            //    });
            //    client.PostAsync("http://localhost:51237/home/addcandidate", formContent).Wait();
            //    System.Console.WriteLine($"Posted {i} of 50");
            //}

            
            //System.Console.WriteLine("Done");

            var url = "https://www.hebcal.com/converter/?cfg=json&gy=2019&gm=5&gd=8&g2h=1";
            var json = client.GetStringAsync(url).Result;
            System.Console.WriteLine(json);

            System.Console.ReadKey(true);
        }
    }
}
