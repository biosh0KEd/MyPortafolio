namespace Portafolio.Data
{
    public class Utils
    {
        public static string GetUrl(string url)
        {
#if DEBUG
            return url;
#else
            return $"/MyPortafolio{url}";
#endif
        }

        public static string StreamToString(Stream obj)
        {
            using var reader = new StreamReader(obj);
            return reader.ReadToEnd();
        }

        #region Skills

        public const int PageTitleSize = 40;
        public const int SectionTitleSize = 30;

        #endregion
    }
}
