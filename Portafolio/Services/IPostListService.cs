using Newtonsoft.Json.Linq;

namespace Portafolio.Services;

public interface IPostListService
{
    public Task<JArray> GetPostsByTech(string tech);
}