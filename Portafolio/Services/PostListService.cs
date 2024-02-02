using Newtonsoft.Json.Linq;

namespace Portafolio.Services;

public class PostListService : IPostListService
{
    private readonly HttpClient _httpClient;
    
    public PostListService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<JArray> GetPostsByTech(string tech)
    {
        var posts = JArray.Parse(await _httpClient.GetStringAsync("data/posts.json"));
        var projects = JArray.Parse(await _httpClient.GetStringAsync("data/projects.json"));

        var result = new JArray();
        
        foreach (var jToken in posts)
        {
            var post = (JObject)jToken;
            var techs = post["techs"]?.ToObject<string[]>();
            if (techs != null && techs.Contains(tech))
            {
                result.Add(post);
            }
        }
        
        foreach (var jToken in projects)
        {
            var project = (JObject)jToken;
            var techs = project["techs"]?.ToObject<string[]>();
            if (techs != null && techs.Contains(tech))
            {
                result.Add(project);
            }
        }
        
        return result;
    }
}