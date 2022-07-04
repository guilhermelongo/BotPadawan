using Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Base
{
    public class CreateApiRepository : ICreateApiRepository
    {
        public async Task InsertAsync(string id)
        {

            HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:44337") };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            Pessoa[] trespessoas = new Pessoa[3];
            var parametro = new { input = trespessoas.ToArray() };

            var jsonContent = JsonConvert.SerializeObject(parametro);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage responseMessage = await client.PostAsync("Person/create", contentString);

            foreach (var pessoa in trespessoas)
            {




                //cont++;
                //if (cont != 3)
                //{
                //    trespessoas.Append(pessoa);
                //}
                //else
                //{
                //    cont = 0;
                    Console.WriteLine("=================================================================");

                }

            }

        }
    }   

