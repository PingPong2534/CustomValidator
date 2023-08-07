using CustomValidator.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace CustomValidator.Infrastructure.Attributes
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ErrorModel errorModel = null;

                foreach (var state in context.ModelState)
                {
                    var jsonError = state.Value.Errors.FirstOrDefault();
                    if (jsonError != null)
                    {
                        try
                        {
                            errorModel = JsonConvert.DeserializeObject<ErrorModel>(jsonError.ErrorMessage);
                            if (errorModel != null)
                            {
                                errorModel.FieldName = state.Key;
                                break;
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                if (errorModel != null)
                {
                    var result = new JsonResult(errorModel);
                    result.StatusCode = StatusCodes.Status400BadRequest;
                    context.Result = result;
                }
            }
        }
    }
}