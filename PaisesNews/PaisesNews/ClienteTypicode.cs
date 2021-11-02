using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace PaisesNews
{
    public class ClienteTypicode
    {
        private readonly HttpClient pais;
        public ClienteTypicode()
        {
            pais = new HttpClient
            {
                BaseAddress = new Uri("https://restcountries.com/v3.1/all")
            };
            pais.DefaultRequestHeaders.Accept.Clear();
            pais.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<List<Comments>> ListarComment()
        {
            List<Comments> comentarios = new List<Comments>();
            try
            {
                comentarios = await pais.GetFromJsonAsync<List<Comments>>("comments");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            return comentarios;
        }

        public async Task InsertarPost(Post nuevoPost)
        {
            try
            {
                var res = await pais.PostAsJsonAsync("posts", nuevoPost);
                if (res.IsSuccessStatusCode)
                {
                    Console.WriteLine("Se Registro El Post.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: (ex.Message)");
            }
        }
    }
}
