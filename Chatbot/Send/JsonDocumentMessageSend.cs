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
