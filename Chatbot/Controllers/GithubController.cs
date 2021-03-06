using Chatbot.Request;
using Chatbot.Send;
using Lime.Protocol;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chatbot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        JsonDocumentMessageSend envio = new JsonDocumentMessageSend();
        RequestGithub request = new RequestGithub();

        /// <summary>
        /// Obtém os repositórios filtrados pelo termo de busca
        /// </summary>
        /// <param name="termoBusca"></param>
        /// <returns>
        /// Uma lista com todos os repositórios em um Objeto JSON
        /// </returns>
        [HttpGet]
        [Route("description/{termoBusca}")]
        public async Task<JsonDocument> getDescription(string termoBusca)
        {
            var repositories = request.getRepository(termoBusca);
            var document = envio.getDescription(repositories);
            return document;
        }
        /// <summary>
        /// Obtém os nomes completos dos repositórios filtrados pelo termo de busca
        /// </summary>
        /// <param name="termoBusca"></param>
        /// <returns>
        /// Uma lista com todos os nomes completos dos repositórios em um Objeto JSON
        /// </returns>
        [HttpGet]
        [Route("fullName/{termoBusca}")]
        public async Task<JsonDocument> getFullName(string termoBusca)
        {
            var repositories = request.getRepository(termoBusca);
            var document = envio.getFullName(repositories);
            return document;
        }
    }
}
