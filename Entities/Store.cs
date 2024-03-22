using Entities.Types;

namespace Entities
{
    public class Store
    {
        public int Id { get; set; }
        public int StoreId { get; set; } //4238
        public string? Name { get; set; }  //  "Name": "Tåsen",
        public ChainInfo? ChainInfo { get; set; }
        public int ChainId { get; set; }
        public bool IsEcommerce { get; set; }       //  "IsEcommerce": false,
        public string? NewspaperUrl { get; set; }   //  "NewspaperUrl": "http://kundeavis.coop.no/aviser/?id=4238",
        public List<InStoreServices>? InStoreServices { get; set; }  // ["memberoffer", "postnord", "post"]
        public int InStoreServiceId { get; set; }
        public double Lat { get; set; } //"Lat": 59.949938,
        public double Lng { get; set; }  //  "Lng": 10.749888,
        public string? OpeningHoursToday { get; set; }  //  "OpeningHoursToday": "07:00-23:00",
        public bool OpenNow { get; set; }  //  "OpenNow": true,
        public string? Phone { get; set; }   //  "Phone": "22237700"     ,
        public string? Address { get; set; }   //  "Address": "NILS LAURITSSØNSV. 57, 0870 OSLO",
        public string? City { get; set; }    //  "City": "Oslo",
        public int Distance { get; set; }    //  "Distance": 0,
        public string? Email { get; set; }      //  "Email": "tasen.prix@coop.no",
        public string? SLag { get; set; }      //  "SLag": "NORSK BUTIKKDRIFT AS",
        public string? OrganizationNumber { get; set; }   //  "OrganizationNumber": "931186744",
        public List<OpeningHours>? OpeningHours { get; set; }
        public int OpeningHoursId { get; set; }
    }
}
