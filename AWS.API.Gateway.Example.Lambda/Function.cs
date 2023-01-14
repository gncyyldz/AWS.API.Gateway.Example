using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWS.API.Gateway.Example.Lambda;

public class Function
{
    public APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest request, ILambdaContext context)
    {
        request.QueryStringParameters.TryGetValue("name", out var name);
        return new()
        {
            Body = $"Merhaba {name ?? "Gençay YILDIZ"}",
            StatusCode = 200
        };
    }
}
