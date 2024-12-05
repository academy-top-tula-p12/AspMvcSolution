using Microsoft.AspNetCore.Mvc;

namespace AspMvcWelcomeApp
{
    public class MyResult : IActionResult
    {
        string html;
        public MyResult(string html)
        {
            this.html = html;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            string page = @$"<!DOCTYPE html>
                            <html lang=""ru"">
                            <head>
                                <title>MyAction Example</title>
                            </head>
                            <body>
                                <h3>{this.html}</h3>
                            </body>
                            </html>";
            await context.HttpContext.Response.WriteAsync(page);
        }
    }
}
