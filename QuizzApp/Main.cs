using System.CodeDom.Compiler;
using System.Net;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using QuizzApp;
namespace QuizzAppAPI
{
    public class APIData
    {
        public string Type { get; set; }
        public string Difficulty { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
        
        [JsonPropertyName("correct_answer")]
        public string CorrectAnswer { get; set; }
    }

    public class APIResponse
    {
        [JsonPropertyName("response_code")]
        public int ResponseCode { get; set; }

        [JsonPropertyName("results")]
        public List<APIData> Results { get; set; }
    }
    

    public class APIClass
    {
        private static HttpClient client = new HttpClient();
        public static async Task<List<APIData>>APIMessage(int count, string type)
        {
        string url = ($"https://opentdb.com/api.php?amount={count}&type={type}");
        APIResponse response =  new APIResponse();
            try
            {
                response = await client.GetFromJsonAsync<APIResponse>(url);
                if (response != null && response.Results != null && response.Results.Count > 0)
                {
                    return response.Results;
                }
                else
                {
                    throw new Exception("test");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(response.ResponseCode.ToString());
                throw new Exception($"{ex.Message}");
            }
        }
    }
}