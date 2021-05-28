using MyKafka.Domain.Entities;

namespace MyKafka.Application.Contracts.DataAccess
{
    public interface IAssociationUnitRepository : IAsyncRepository<AssociationUnit>
    {
    }
}
