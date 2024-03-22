using Entities.Types;

namespace Entities
{
    public class OpeningHours
    {
        public int Id { get; set; }
        public DateOnly Dato { get; set; } // "19/03"
        public string? OpenString { get; set; } //"07:00-23:00"
        public Weekdays Weekdays { get; set; } // "Monday", Tuesday, osv
        public bool Closed { get; set; } //false
        public bool SpecialOpeningHours { get; set; } // false
        public int StoreId { get; set; }
    }
}
