using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TestExam_297125_Exam_S21.Models;

namespace AuthorBlazor.Data
{
    public class AuthorManager : IAuthorManager
    {
        
        private HttpClient Client;
        private String Uri;

        public AuthorManager()
        {
            Client = new HttpClient();
            Uri = "https://localhost:5004";
        }
        
        
        public async Task<bool> createAuthor(Author author)
        {
            String productAsJson = JsonSerializer.Serialize(author);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri + "/author",  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                
                string result = await responseMessage.Content.ReadAsStringAsync();
                bool response = JsonSerializer.Deserialize<bool>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return response;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }

        public async Task<IList<Author>> getAuthors()
        {
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/author/" );
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                IList<Author> authors = JsonSerializer.Deserialize<IList<Author>>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return authors;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
    }
}