namespace YaylaVilla.WebUI.Settings
{
    public class ServiceApiSettings
    {
        public string ApiServerUrl { get; set; }
        public ApiService Category { get; set; }
        public ApiService About { get; set; }
        public ApiService Address { get; set; }
        public ApiService Blog { get; set; }
        public ApiService Comment { get; set; }
        public ApiService Contact { get; set; }
        public ApiService Product { get; set; }
        public ApiService Service { get; set; }
        public ApiService TagCloud { get; set; }
        public ApiService Testimonial { get; set; }
        public ApiService WorkFlow { get; set; }
    }

    public class ApiService
    {
        public string Path { get; set; }
    }
}
