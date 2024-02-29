using System.Text.Json;

namespace PokemonAPI.ResponseHandlers
{
    public class SendResponses
    {
        public static void SendOkResponse<T>(HttpContext context, T? data , string message)
        {
            context.Response.StatusCode = 200;
            context.Response.ContentType = "application/json";
            context.Response.WriteAsync(JsonSerializer.Serialize(new { message, data }));
        }
        public static void SendCreatedResponse(HttpContext context, string message)
        {
            SetResponseWithoutData(context, 201, message);
        }

        public static void SendNoContentResponse(HttpContext context)
        {
            context.Response.StatusCode = 204;
            context.Response.ContentType = "application/json";
        }

        public static void SendBadRequestResponse(HttpContext context)
        {
            SetResponseWithoutData(context, 400, "Bad Request");
        }

        public static void SendNotFoundResponse(HttpContext context, string message)
        {
            SetResponseWithoutData(context, 404, message);
        }

        public static void SendInternalServerErrorResponse(HttpContext context, string message)
        {
            SetResponseWithoutData(context, 500, message);
        }
        private static void SetResponseWithoutData(HttpContext context, int statusCode, string message)
        {
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";
            context.Response.WriteAsync(JsonSerializer.Serialize(new { message }));
        }
    }
}
