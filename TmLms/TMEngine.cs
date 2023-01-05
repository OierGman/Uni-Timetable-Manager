using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TmLms
{
    public sealed class TMEngine
    {
        public Dictionary<int,TM.CourseInfo> CourseDictionary { get; set; }

        public Dictionary<int, TM.Module> ModuleDictionary { get; set; }

        private static readonly TMEngine instance = new TMEngine();

        static TMEngine()
        {
        }

        private TMEngine()
        {
            CourseDictionary = new Dictionary<int, TM.CourseInfo>();
            ModuleDictionary = new Dictionary<int, TM.Module>();
        }

        public static TMEngine Instance
        {
            get
            {
                return instance;
            }
        }

        // API for test builder, instructor can pick categories, difficulty and number of questions
        // question type is limited to bool and multiple choice
        // API key required
        // https://opentdb.com/api_config.php

        public static async Task GetQuiz(string seed)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://opentdb.com/api.php?" + seed);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // string responseBody = await client.GetStringAsync(uri);
                QuizJson.Root quizclass = JsonSerializer.Deserialize<QuizJson.Root>(responseBody);

                if (quizclass.response_code == 0)
                {
                    foreach (var x in quizclass.results)
                    {
                        QuizJson.roots.Add(x);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception exception)
            {
                if (exception is HttpRequestException)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", exception.Message);
                }
            }
        }

        public static async Task GetCategories()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://opentdb.com/api_category.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Categories.Root categoryclass = JsonSerializer.Deserialize<Categories.Root>(responseBody);

                foreach (var x in categoryclass.trivia_categories)
                {
                    Categories.categories.Add(x);
                }
            }
            catch (Exception exception)
            {
                if (exception is HttpRequestException)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", exception.Message);
                }
            }
        }

    }
}
