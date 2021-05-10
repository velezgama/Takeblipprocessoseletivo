using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Takeblip_intermediario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        {
    class Program
        {
            static void Main(string[] args)
            {
                var requisicaoWeb = System.Net.WebRequest.CreateHttp("https://github.com/takenet/library.data");
                requisicaoWeb.Method = "GET";
                requisicaoWeb.UserAgent = "RequisicaoWebDemo";
                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();
                    var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString());
                    Console.WriteLine(post.Id + " " + post.title + " " + post.body);
                    Console.ReadLine();
                    streamDados.Close();
                    resposta.Close();
                }
                Console.ReadLine();
            }
        }
    }
}
}
