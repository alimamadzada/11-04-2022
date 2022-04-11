using JsonHomework.Files;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace JsonHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string jsonResp = client.GetStringAsync(@"https://jsonplaceholder.typicode.com/posts").Result;

            List<Posts> posts = JsonConvert.DeserializeObject<List<Posts>>(jsonResp);

            foreach (var item in posts)
            {
                Console.WriteLine(item.title);
            }
        }
    }
}
