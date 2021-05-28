using Moq;
using MyKafka.Application.Contracts.DataAccess;
using System.Collections.Generic;

namespace MyKafka.Tests.Common.ExtensionMethods
{
    public static class MockIRepositoryExtensions
    {


        public static void SetupCreate<TModel>(this Mock<IAsyncRepository<TModel>> repository, IList<TModel> mockList)
            where TModel : class
        {
            repository.Setup(_ => _.AddAsync(It.IsAny<TModel>())).Callback((TModel toAdd) => mockList.Add(toAdd));
        }
    }
}
