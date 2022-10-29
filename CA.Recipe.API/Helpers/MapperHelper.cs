using AutoMapper;
using CA.Recipe.Handlers.CalculosCuotasHandler;
using CA.Recipe.ModelViews;

namespace CA.Recipe.API.Helpers
{
    public class MapperHelper
    {
        internal static IMapper mapper;

        static MapperHelper()
        {
            var config = new MapperConfiguration(x =>
            {
                #region GetExampleValue
                x.CreateMap<MVGetExampleValueResponse, GetExampleValueResponse>()
                .ForMember(mv => mv.Value, model => model.MapFrom(m => m.ExampleValue)).ReverseMap();
                #endregion

                #region GetRecipeValue
                x.CreateMap<MVGetRecipeValueResponse, GetExampleRecipeResponse>().ReverseMap();
                #endregion
            });

            mapper = config.CreateMapper();
        }

        public static T Map<T>(object source)
        {
            return mapper.Map<T>(source);
        }
    }
}