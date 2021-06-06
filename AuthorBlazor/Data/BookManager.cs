using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TestExam_297125_Exam_S21.Models;

namespace AuthorBlazor.Data
{
    public class BookManager : IBookManager
    {
        
        private HttpClient Client;
        private String Uri;

        public BookManager()
        {
            Client = new HttpClient();
            Uri = "https://localhost:5004";
        }
        
        public async Task<IList<Book>> GetBooks()
        {
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/book" );
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                IList<Book> books = JsonSerializer.Deserialize<IList<Book>>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return books;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }

        public async Task<bool> AddBook(Book book, int authorId)
        {
            String productAsJson = JsonSerializer.Serialize(book);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri + "/book/" + authorId,  content);
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

        public async Task<bool> removeBook(int bookIsbn)
        {
            
            HttpResponseMessage responseMessage = await Client.DeleteAsync( Uri + "/book/" + bookIsbn);
            if (responseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }
    }
}