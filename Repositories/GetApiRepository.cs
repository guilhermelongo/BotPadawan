using Models.Entities;
using Models.Entities.IEntities;
using Newtonsoft.Json;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Repositories
{

    public class GetApiRepository : IGetPessoaRepository

    {
        int cont = 0;
        int aux = 0;
        
        public async Task GetIdAsync(string valor)
        {
            int valor2 = int.Parse(valor);
            Console.WriteLine("Qantidade de pessoas: " + valor);
            valor2 = valor2 - 1;
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:44337") };
            var response = await client.GetAsync("Person/list");
            var content = await response.Content.ReadAsStringAsync();

            var usuarios = JsonConvert.DeserializeObject<Pessoa[]>(content);
            usuarios.ToList();
            List<PessoaPost> pessoaList = new List<PessoaPost>();

            foreach (var user in usuarios)
            {
                
                aux++;
                cont++;
                PessoaPost pessoaPost = new PessoaPost();
                pessoaPost.Cpf = user.Cpf;
                pessoaPost.Name = user.Nome;
                pessoaPost.BirthDate = user.DataNascimento;
                pessoaPost.Gender = user.Sexo;
                pessoaList.Add(pessoaPost);
                if (cont == 3)
                {
                    cont = 0;
                    var userserealize = JsonConvert.SerializeObject(pessoaList);
                    var payload = new StringContent(userserealize, Encoding.UTF8, "application/Json");
                    var result = await client.PostAsync(client.BaseAddress + "Person/create", payload).Result.Content.ReadAsStringAsync();
                    pessoaList.Clear();


                }
                else if (aux > valor2)
                {
                    var userserealize = JsonConvert.SerializeObject(pessoaList);
                    var payload = new StringContent(userserealize, Encoding.UTF8, "application/Json");
                    var result = await client.PostAsync(client.BaseAddress + "Person/create", payload).Result.Content.ReadAsStringAsync();
                    pessoaList.Clear();
                }

                              
            }


        }

    }
}
//Console.WriteLine("Nome: " + pessoaPost.Name + "\nCpf: " + pessoaPost.Cpf + "\nXEZU: " + pessoaPost.Gender + "\nDatadeNascimento: " + pessoaPost.BirthDate + "\n");