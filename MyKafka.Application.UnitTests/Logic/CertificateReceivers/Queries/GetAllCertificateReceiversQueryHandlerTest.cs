using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using Moq;
using MyKafka.Application.Contracts.DataAccess;
using MyKafka.Application.Logic.CertificateReceivers.Queries;
using MyKafka.Application.Profiles.CertificateReceivers;
using MyKafka.Domain.Entities;
using MyKafka.Tests.Common.ExtensionMethods;
using Xunit;

namespace MyKafka.Application.UnitTests.Logic.CertificateReceivers.Queries
{
    public class GetAllCertificateReceiversQueryHandlerTest
    {
        // Arrange-Act-Assert
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<CertificateReceiver>> _certificateRepository;
        private readonly IList<CertificateReceiver> _certificateReceivers;


        public GetAllCertificateReceiversQueryHandlerTest()
        {
            var configurationProvider = new MapperConfiguration(cfg =>
           {
               cfg.AddProfile<CertificateReceiverMappingProfile>();
           });

            _mapper = configurationProvider.CreateMapper();

            _certificateRepository = new Mock<IAsyncRepository<CertificateReceiver>>();
            _certificateReceivers = new List<CertificateReceiver>
            {
                new()
                {
                    Name = "test",
                    Id = 1
                }
            };

            _certificateRepository.SetupCreate(_certificateReceivers);
        }

        [Fact]
        public async Task Correct_Input_Should_Handle_Successfully()
        {
            //Arrange
            var handler = new GetAllCertificateReceiversQueryHandler(_certificateRepository.Object, _mapper);

            //Act
            var result = await handler.Handle(new GetAllCertificateReceiversQuery(), CancellationToken.None);

            //Assert
            result.Should().BeOfType<GetAllCertificateReceiverListDto>();
            result.CertificateReceivers.Should().HaveCount(0);
        }
    }
}