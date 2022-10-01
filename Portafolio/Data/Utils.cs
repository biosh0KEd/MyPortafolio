namespace Portafolio.Data
{
    public class Utils
    {
        public static string getURL(string url)
        {
#if DEBUG
            return url;
#else
            return $"/MyPortafolio{url}";
#endif
        }
    }
}
