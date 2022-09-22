using CA.Recipe.Data.Db.UnitOfWork;
using CA.Recipe.Utils.GenericClass;
using System.Collections.Generic;

namespace CA.Recipe.Handlers.CalculosCuotasHandler
{
    public class ExampleInteractor : IExample
    {
        private UoWData UoWData { get; set; }

        public static ExampleInteractor Create() => new ExampleInteractor();

        public ExampleInteractor()
        {
            UoWData = UoWData.Create();
        }

        public ResponseBase<List<GetExampleValueResponse>> GetExampleValues()
        {
            List<GetExampleValueResponse> data = new List<GetExampleValueResponse>();
            data.Add(new GetExampleValueResponse { Value = 1});
            data.Add(new GetExampleValueResponse { Value = 2 });
            data.Add(new GetExampleValueResponse { Value = 3 });
            return ResponseBase<List<GetExampleValueResponse>>.Create(data);
        }

        public void Dispose()
        {
            this.UoWData.Dispose();
            this.UoWData = null;
        }
    }
}
