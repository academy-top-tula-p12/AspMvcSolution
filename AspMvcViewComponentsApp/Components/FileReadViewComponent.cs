using Microsoft.AspNetCore.Mvc;

namespace AspMvcViewComponentsApp.Components
{
    public class FileReadViewComponent : ViewComponent
    {
        public async Task<string> InvokeAsync()
        {
            using (StreamReader reader = new StreamReader("Resource/file01.txt"))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
