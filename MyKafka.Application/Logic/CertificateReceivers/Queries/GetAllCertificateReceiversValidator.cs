using MyKafka.Application.Responses.Validation;
using MyKafka.Application.Validation;
using System.Threading;
using System.Threading.Tasks;

namespace MyKafka.Application.Logic.CertificateReceivers.Queries
{
    public class GetAllCertificateReceiversValidator : RequestValidator<GetAllCertificateReceiversQuery, GetAllCertificateReceiverListDto>
    {
        protected override async Task<ValidationBag> Validate(GetAllCertificateReceiversQuery request, CancellationToken cancellationToken)
        {
            var bag = new ValidationBag();


            return bag;
        }
    }
}