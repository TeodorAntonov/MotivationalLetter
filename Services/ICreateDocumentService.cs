using Entities;

namespace Services
{
    public interface ICreateDocumentService
    {
        Task CreateDcoument(PersonInfo personInfo);
    }
}
