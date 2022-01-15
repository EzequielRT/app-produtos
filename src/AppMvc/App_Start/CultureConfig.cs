using System.Globalization;

namespace AppMvc.App_Start
{
    public class CultureConfig
    {
        public static void RegisterConfig()
        {
            var culture = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;
        }
    }
}