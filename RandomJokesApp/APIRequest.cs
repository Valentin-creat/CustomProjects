using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace RandomJokesApp
{


    public class APIRequest
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("setup")]
        public string Setup { get; set; }

        [JsonPropertyName("punchline")]
        public string Punchline { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

    }




    public class APIClass
    {
        static HttpClient client = new HttpClient();
        public static async Task<APIRequest>APIContent()
        {
            string url = ($"https://official-joke-api.appspot.com/random_joke");
            
            try
            {
                var response = await client.GetFromJsonAsync<APIRequest>(url);

                if (response != null)
                {
                    return response;
                }
                else
                {
                    throw new Exception("test");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
