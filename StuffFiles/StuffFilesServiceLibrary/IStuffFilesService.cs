using System.ServiceModel;

namespace StuffFilesServiceLibrary
{
    [ServiceContract]
    public interface IStuffFilesService
    {
        [OperationContract]
        string GetGreetings(string Name);
    }
}
