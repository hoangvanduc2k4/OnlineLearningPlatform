using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace OnlineLearningPlatform.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HandleError(int statusCode)
        {
            var feature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            Console.WriteLine($"Error visited: {feature?.OriginalPath}");

            string errorTitle = "Error";
            string errorMessage;

            switch (statusCode)
            {
                case 404:
                    errorTitle = "Page Not Found";
                    errorMessage = "The page you are looking for does not exist, has been removed, or renamed.";
                    break;
                case 500:
                    errorTitle = "Internal Server Error";
                    errorMessage = "An unexpected error occurred on the server. Please try again later.";
                    break;
                case 403:
                    errorTitle = "Forbidden";
                    errorMessage = "You do not have permission to access this resource.";
                    break;
                case 401:
                    errorTitle = "Unauthorized";
                    errorMessage = "You must log in to perform this action.";
                    break;
                default:
                    errorTitle = "An Error Occurred";
                    errorMessage = $"An error occurred with code: {statusCode}.";
                    break;
            }

            ViewBag.StatusCode = statusCode;
            ViewBag.ErrorTitle = errorTitle;
            ViewBag.ErrorMessage = errorMessage;

            return View("Error");
        }
    }
}
