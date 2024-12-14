namespace AspMvcViewComponentsApp.Components
{
    public class DateViewComponent
    {
        public string Invoke()
        {
            return $"Date: {DateTime.Now.ToLongDateString()}";
        }
    }
}
