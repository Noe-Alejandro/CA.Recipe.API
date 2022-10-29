using CA.Recipe.Handlers.CalculosCuotasHandler;

namespace CA.Recipe.ModelViews
{
    #region MV GetExampleValue
    /// <summary>
    /// Respuesta de GetExampleValue
    /// </summary>
    public class MVGetExampleValueResponse
    {
        public int ExampleValue { get; set; }
    }
    #endregion

    #region MV GetRecipeValue
    /// <summary>
    /// Respuesta de GetRecipeValue
    /// </summary>
    public class MVGetRecipeValueResponse : GetExampleRecipeResponse
    {
    }
    #endregion
}
