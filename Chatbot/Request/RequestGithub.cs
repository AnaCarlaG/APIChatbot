using Octokit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chatbot.Request
{
    public class RequestGithub
    {
        /// <summary>
        /// Método para obter 5 repositórios do Github
        /// </summary>
        /// <param name="termoBusca"></param>
        /// <returns>
        /// Uma lista de repositórios
        /// </returns>
        public async Task<IList<Repository>> getRepository(string termoBusca)
        {
            var github = new GitHubClient(new ProductHeaderValue("ChatBot"));
            var request = new SearchRepositoriesRequest(termoBusca)
            {
                // how about we restrict the language the library is written in
                Language = Language.CSharp,

                // or go all out and search the readme, name or description
                In = new[] { InQualifier.Readme, InQualifier.Description, InQualifier.Name },

                // we can also restrict the owner of the repo if we so wish
                User = "takenet"
            };

            var result = await github.Search.SearchRepo(request);
            var listRepos = result.Items;

            SortedList<DateTimeOffset, Repository> sortByDate = new SortedList<DateTimeOffset, Repository>();
            int count_repo = 0;


            foreach (var repo in listRepos)
            {

                sortByDate.Add(repo.CreatedAt, repo);
                count_repo++;
                if (count_repo == 5) break;
            }
            return sortByDate.Values;
        }
    }
}
