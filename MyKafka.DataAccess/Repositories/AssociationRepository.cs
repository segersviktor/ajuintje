using MyKafka.Application.Contracts.DataAccess;
using MyKafka.Domain.Entities;

namespace MyKafka.DataAccess.Repositories
{
    public class AssociationRepository : BaseRepository<Association>, IAssociationRepository
    {
        public AssociationRepository(MyKafkaDbContext dbContext) : base(dbContext)
        {
        }
    }
}