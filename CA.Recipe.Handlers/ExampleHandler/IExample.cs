using CA.Recipe.Utils.GenericClass;
using System;
using System.Collections.Generic;

namespace CA.Recipe.Handlers.CalculosCuotasHandler
{
    public interface IExample : IDisposable
    {
        /// <summary>
        /// Devuelve 0
        /// </summary>
        /// <returns></returns>
        ResponseBase<List<GetExampleValueResponse>> GetExampleValues();
    }
}
