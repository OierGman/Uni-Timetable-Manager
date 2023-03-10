using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TmLms
{
    public  class QuizJson
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

        public static List<QuizJson.Result> roots = new List<QuizJson.Result>();

        public class Result
        {
            [JsonPropertyName("category")]
            public string category { get; set; }

            [JsonPropertyName("type")]
            public string type { get; set; }

            [JsonPropertyName("difficulty")]
            public string difficulty { get; set; }

            [JsonPropertyName("question")]
            public string question { get; set; }

            [JsonPropertyName("correct_answer")]
            public string correct_answer { get; set; }

            [JsonPropertyName("incorrect_answers")]
            public List<string> incorrect_answers { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("response_code")]
            public int response_code { get; set; }

            [JsonPropertyName("results")]
            public List<Result> results { get; set; }
        }
    }

    public class Categories
    {
        public static List<TriviaCategory> categories = new List<TriviaCategory>();

        public class Root
        {
            [JsonPropertyName("trivia_categories")]
            public List<TriviaCategory> trivia_categories { get; set; }
        }

        public class TriviaCategory
        {
            [JsonPropertyName("id")]
            public int id { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }
        }
    }
}
