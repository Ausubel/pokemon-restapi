using Microsoft.AspNetCore.Mvc;
using PokemonAPI.ResponseHandlers;

namespace PokemonAPI.Utils
{
    public class VerifyResponse
    {
        public void ExecuteAction(HttpContext context, Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                SendResponses.SendInternalServerErrorResponse(context, ex.Message);
            }
        }
    }
}
