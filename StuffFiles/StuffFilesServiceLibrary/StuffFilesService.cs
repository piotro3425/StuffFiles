namespace StuffFilesServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class StuffFilesService : IStuffFilesService
    {
        public string GetGreetings(string Name) => $"Hello {Name}";
    }
}
