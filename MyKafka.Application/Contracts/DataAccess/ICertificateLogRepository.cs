using MyKafka.Domain.Entities;

namespace MyKafka.Application.Contracts.DataAccess
{
    public interface ICertificateLogRepository : IAsyncRepository<CertificateLog>
    {
    }
}
