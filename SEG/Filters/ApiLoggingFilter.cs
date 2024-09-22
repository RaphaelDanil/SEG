using Microsoft.AspNetCore.Mvc.Filters;

namespace SEG.Filters;

public class ApiLoggingFilter : IActionFilter
{
    private readonly ILogger<ApiLoggingFilter> _logger;

    public ApiLoggingFilter(ILogger<ApiLoggingFilter> logger)
    {
        _logger = logger;
    }


    public void OnActionExecuting(ActionExecutingContext context)
    {
        //Executa antes dos action/métodos
        _logger.LogInformation("Executando -> OnActionExecuting");
        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()}");
        _logger.LogInformation($"Model State: {context.ModelState.IsValid}");
        _logger.LogInformation("################");
    }
    public void OnActionExecuted(ActionExecutedContext context)
    {
        //Executa após a finalização do action
        _logger.LogInformation("Executando -> OnActionExecuting");
        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()}");
        _logger.LogInformation($"Status Code: {context.HttpContext.Response.StatusCode}");
        _logger.LogInformation("################");
    }
}
