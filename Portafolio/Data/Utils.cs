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

        public static string toString(Stream obj)
        {
            using StreamReader reader = new StreamReader(obj);
            return reader.ReadToEnd();
        }
    }
}
