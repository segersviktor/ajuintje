using MediatR;

namespace MyKafka.Application.Logic.CertificateReceivers.Queries
{
    public class GetAllCertificateReceiversQuery : IRequest<GetAllCertificateReceiverListDto>
    {

    }
}