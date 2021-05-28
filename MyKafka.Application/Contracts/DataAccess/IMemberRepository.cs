using MyKafka.Domain.Entities;

namespace MyKafka.Application.Contracts.DataAccess
{
    public interface IMemberRepository : IAsyncRepository<Member>
    {
    }
}
