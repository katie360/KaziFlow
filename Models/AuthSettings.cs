namespace KaziFlowApi.Models
{
    public class AuthSettings
    {
        public string Key { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public double ExpiryHours { get; set; }
    }
}
