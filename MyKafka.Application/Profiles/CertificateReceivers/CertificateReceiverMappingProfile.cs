using AutoMapper;
using MyKafka.Application.Logic.CertificateReceivers.Queries;
using MyKafka.Domain.Entities;

namespace MyKafka.Application.Profiles.CertificateReceivers
{
    public class CertificateReceiverMappingProfile : Profile
    {
        public CertificateReceiverMappingProfile()
        {
            CreateMap<CertificateReceiver, CertificateReceiverDto>().ReverseMap();
        }
    }
}