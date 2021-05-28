using MyKafka.Application.Responses;
using System.Collections.Generic;

namespace MyKafka.Application.Logic.CertificateReceivers.Queries
{
    public class GetAllCertificateReceiverListDto : BaseResponse
    {
        public IEnumerable<CertificateReceiverDto> CertificateReceivers { get; set; }
    }

    public class CertificateReceiverDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}