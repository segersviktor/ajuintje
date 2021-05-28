using MyKafka.Application.Contracts.DataAccess;
using MyKafka.Domain.Entities;

namespace MyKafka.DataAccess.Repositories
{
    public class AssociationUnitRepository : BaseRepository<AssociationUnit>, IAssociationUnitRepository
    {
        public AssociationUnitRepository(MyKafkaDbContext dbContext) : base(dbContext)
        {
        }
    }
}