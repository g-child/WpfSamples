namespace WpfSamples.GenericHostSample.Models
{
    public class MyUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Text => $"Id: {Id}\nName: {Name}\nAddress: {Address}";
    }
}
