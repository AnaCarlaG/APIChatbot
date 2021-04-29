using Lime.Protocol;
using Octokit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chatbot.Send
{
    public class JsonDocumentMessageSend
    {
        JsonDocument jsonDocumentsDescription = new JsonDocument();
        JsonDocument jsonDocumentsFullName = new JsonDocument();

        /// <summary>
        /// Obter as descrições do repositório
        /// </summary>
        /// <param name="repositories"></param>
        /// <returns>
        /// retorna um objeto JSON
        /// </returns>
        public JsonDocument getDescription(Task<IList<Repository>> repositories)
        {
            int count = 0;
            foreach (var item in repositories.Result)
            {
                jsonDocumentsDescription.Add(count.ToString(), item.Description);
                count++;
            }

            jsonDocumentsDescription.SetMediaType("application/json");
            return jsonDocumentsDescription;
        }
        /// <summary>
        /// Obtém o nome completo do repositório
        /// </summary>
        /// <param name="repositories"></param>
        /// <returns>
        /// retorna um objeto JSON
        /// </returns>
        public JsonDocument getFullName(Task<IList<Repository>> repositories)
        {
            int count = 0;
            foreach (var item in repositories.Result)
            {
                jsonDocumentsFullName.Add(count.ToString(), item.FullName);
                count++;
            }

            jsonDocumentsFullName.SetMediaType("application/json");
            return jsonDocumentsFullName;
        }
    }
}
