using Lime.Protocol;
using Microsoft.AspNetCore.Mvc;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Take.Blip.Client;

namespace Chatbot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        OptionDocumentCollectionMessageReceiver envio = new OptionDocumentCollectionMessageReceiver();
        RequestGithub request = new RequestGithub();
        [HttpGet]
        [Route("description/{termoBusca}")]
        public async Task<JsonDocument> getDescription(string termoBusca)
        {
            var repositories = request.getRepository(termoBusca);
            var document = envio.getDescription(repositories);
            return document;
        }
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
