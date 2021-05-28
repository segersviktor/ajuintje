using MyKafka.Application.Contracts.DataAccess;
using MyKafka.Domain.Entities;

namespace MyKafka.DataAccess.Repositories
{
    public class MemberRepository : BaseRepository<Member>, IMemberRepository
    {
        public MemberRepository(MyKafkaDbContext dbContext) : base(dbContext)
        {
        }
    }
}