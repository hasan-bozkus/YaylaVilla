namespace YaylaVilla.WebUI.Settings
{
    public class ServiceApiSettings
    {
        public string ApiServerUrl { get; set; }
        public ApiService Category { get; set; }
        public ApiService About { get; set; }
    }

    public class ApiService
    {
        public string Path { get; set; }
    }
}
