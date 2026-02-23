namespace CrmUno.Identity.API.Extensions
{
    public class AppSettings
    {
        public string Secret { get; set; }

        public double ExpirationTime { get; set; }

        public string Emissor { get; set; }

        public string ValidAt { get; set; }
    }
}
