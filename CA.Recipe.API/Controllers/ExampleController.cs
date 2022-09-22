using CA.Recipe.API.Helpers;
using CA.Recipe.Handlers.CalculosCuotasHandler;
using CA.Recipe.ModelViews;
using CA.Recipe.Utils.GenericClass;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace CA.Recipe.API.Controllers
{
    public class ExampleController : ApiController
    {
        public IExample GetInteractor()
        {
            return ExampleInteractor.Create();
        }

        [HttpGet]
        [Route("~/api/ExampleValue")]
        public IHttpActionResult GetExampleValues()
        {
            try
            {
                using (var interactor = GetInteractor())
                {
                    var response = interactor.GetExampleValues();

                    var mvReponse = new ResponseBase<List<MVGetExampleValueResponse>>()
                    {
                        Data = MapperHelper.Map<List<MVGetExampleValueResponse>>(response.Data),
                        Errors = response.Errors,
                        Status = response.Status
                    };

                    if (mvReponse.Status)
                        return Content(HttpStatusCode.OK, mvReponse);

                    return Content(HttpStatusCode.BadRequest, mvReponse);
                }
            }
            catch (Exception e)
            {

                return Content(HttpStatusCode.InternalServerError, ResponseBase<List<MVGetExampleValueResponse>>.Create(new List<string>()
                {
                    e.Message
                }));
            }
        }
    }
}