using Amazon.Lambda.Core;
using System;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MyFirtsLambda;

public class SumaFunction
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input">The event for the Lambda function handler to process.</param>
    /// <param name="context">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
    /// <returns></returns>
    public string FunctionHandler(Operacion input, ILambdaContext context)
    {
        LambdaLogger.Log("Llamando a la funcion: " + context.FunctionName + " a las: " + DateTime.Now);
        int resultado = input.Numero1 + input.Numero2;
        return $"Resultado de: { input.Numero1 } + { input.Numero2 } es { resultado }";
    }
}
