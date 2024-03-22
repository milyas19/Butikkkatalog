using Application.Type;

namespace Application.Feature.Store
{
    public class OpeningHoursDto
    {
        public int Id { get; set; }
        public DateOnly Dato { get; set; } 
        public string? OpenString { get; set; } 
        public Weekdays Weekdays { get; set; } 
        public bool Closed { get; set; } 
        public bool SpecialOpeningHours { get; set; }
        public int StoreId { get; set; }
    }
}