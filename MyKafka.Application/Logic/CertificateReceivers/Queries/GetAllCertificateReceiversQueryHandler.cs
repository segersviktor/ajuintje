using AutoMapper;
using MediatR;
using MyKafka.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MyKafka.Application.Contracts.DataAccess;

namespace MyKafka.Application.Logic.CertificateReceivers.Queries
{
    public class GetAllCertificateReceiversQueryHandler : IRequestHandler<GetAllCertificateReceiversQuery, GetAllCertificateReceiverListDto>
    {

        private readonly IAsyncRepository<CertificateReceiver> _certificateRepository;
        private readonly IMapper _mapper;

        public GetAllCertificateReceiversQueryHandler(IAsyncRepository<CertificateReceiver> certificateRepository, IMapper mapper)
        {
            _certificateRepository = certificateRepository;
            _mapper = mapper;
        }

        public async Task<GetAllCertificateReceiverListDto> Handle(GetAllCertificateReceiversQuery request, CancellationToken cancellationToken)
        {
            var allReceivers = (await _certificateRepository.ListAllAsync()).OrderBy(_ => _.Name);
            return new GetAllCertificateReceiverListDto
            {
                CertificateReceivers = _mapper.Map<IEnumerable<CertificateReceiverDto>>(allReceivers)
            };
        }
    }
}