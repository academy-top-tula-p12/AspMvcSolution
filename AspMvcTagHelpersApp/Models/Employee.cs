namespace AspMvcTagHelpersApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }

    }
}
