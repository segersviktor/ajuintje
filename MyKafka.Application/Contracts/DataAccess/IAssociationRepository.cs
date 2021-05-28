using MyKafka.Domain.Entities;

namespace MyKafka.Application.Contracts.DataAccess
{
    public interface IAssociationRepository : IAsyncRepository<Association>
    {
    }
}
