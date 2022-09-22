using CA.Recipe.Handlers.CalculosCuotasHandler;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;

namespace CA.Recipe.Testing
{
    public class ExampleInteractor_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ExampleValue_Test()
        {
            var expectedValue = new List<GetExampleValueResponse>();
            expectedValue.Add(new GetExampleValueResponse { Value = 1 });
            expectedValue.Add(new GetExampleValueResponse { Value = 2 });
            expectedValue.Add(new GetExampleValueResponse { Value = 3 });

            var service = ExampleInteractor.Create();
            var data = JsonConvert.SerializeObject(service.GetExampleValues().Data);

            Assert.AreEqual(JsonConvert.SerializeObject(expectedValue), data);
        }
    }
}