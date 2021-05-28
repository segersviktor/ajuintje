using MyKafka.Application.Contracts.DataAccess;
using MyKafka.Domain.Entities;

namespace MyKafka.DataAccess.Repositories
{
    public class CertificateLogRepository : BaseRepository<CertificateLog>, ICertificateLogRepository
    {
        public CertificateLogRepository(MyKafkaDbContext dbContext) : base(dbContext)
        {
        }
    }
}