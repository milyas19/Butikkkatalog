using Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.DBContextConfig;

namespace Persistence
{
    public class ButikkKatalogContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<OpeningHoursSpecial> OpeningHoursSpecials { get; set; }
        public DbSet<OpeningHours> OpeningHours { get; set; }
        public DbSet<ChainInfo> ChainInfos { get; set; }
        public DbSet<InStoreServices> InStoreServices { get; set; }


        public ButikkKatalogContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new StoreConfig());
            builder.ApplyConfiguration(new OpeningHoursConfig());
            builder.ApplyConfiguration(new ChainInfoConfig());
            builder.ApplyConfiguration(new OpeningHoursSpecialConfig());
            builder.ApplyConfiguration(new InStoreServiceConfig());



            builder.Entity<ChainInfo>().HasData(
               new ChainInfo
               {
                   Id = 1,
                   Chain = "Prix",
                   ChainClassName = "prix",
                   ChainNr = "01",
                   ChainImage = "/assets/images/mapmarkers/01.png?7003341bcfe337a104c5a8ee79251d4d",
               },
               new ChainInfo
               {
                   Id = 2,
                   Chain = "Mega",
                   ChainClassName = "mega",
                   ChainNr = "03",
                   ChainImage = "/assets/images/mapmarkers/03.png?d7b089ef57ad29e69c3520f42bc8aae1",
               },
               new ChainInfo
               {
                   Id = 3,
                   Chain = "Extra",
                   ChainClassName = "extra",
                   ChainNr = "07",
                   ChainImage = "/assets/images/mapmarkers/07.png?938d3bb66e14f3c8dd9fc5b45feb4fce",
               });


            builder.Entity<InStoreServices>().HasData(
               new InStoreServices
               {
                   Id = 1,
                   MemberOffer = true,
                   Post = false,
                   Postnord = true,
               },
               new InStoreServices
               {
                   Id = 2,
                   MemberOffer = true,
                   Post = false,
                   Postnord = true,
               },
               new InStoreServices
               {
                   Id = 3,
                   MemberOffer = true,
                   Post = false,
                   Postnord = true,
               },
               new InStoreServices
               {
                   Id = 4,
                   MemberOffer = true,
                   Post = false,
                   Postnord = true,
               },
               new InStoreServices
               {
                   Id = 5,
                   MemberOffer = true,
                   Post = false,
                   Postnord = true,
               },
               new InStoreServices
               {
                   Id = 6,
                   MemberOffer = true,
                   Post = false,
                   Postnord = true,
               },
               new InStoreServices
               {
                   Id = 7,
                   MemberOffer = true,
                   Post = false,
                   Postnord = true,
               });

            builder.Entity<OpeningHours>().HasData(
                        new OpeningHours
                        {
                            Id = 1,
                            Dato = new DateOnly(2024, 03, 19),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Tirsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 7
                        },
                        new OpeningHours
                        {
                            Id = 2,
                            Dato = new DateOnly(2024, 03, 20),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Onsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 1
                        },
                        new OpeningHours
                        {
                            Id = 3,
                            Dato = new DateOnly(2024, 03, 21),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Torsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 1
                        },
                        new OpeningHours
                        {
                            Id = 4,
                            Dato = new DateOnly(2024, 03, 22),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Fredag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 1
                        },
                        new OpeningHours
                        {
                            Id = 5,
                            Dato = new DateOnly(2024, 03, 23),
                            OpenString = "08:00-21:00",
                            Weekdays = Entities.Types.Weekdays.Lørdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 1
                        },
                        new OpeningHours
                        {
                            Id = 6,
                            Dato = new DateOnly(2024, 03, 24),
                            OpenString = "Stengt",
                            Weekdays = Entities.Types.Weekdays.Søndag,
                            Closed = true,
                            SpecialOpeningHours = false,
                            StoreId = 1
                        },
                        new OpeningHours
                        {
                            Id = 7,
                            Dato = new DateOnly(2024, 03, 19),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Tirsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 1
                        },
                        new OpeningHours
                        {
                            Id = 8,
                            Dato = new DateOnly(2024, 03, 20),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Onsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 1
                        },
                        new OpeningHours
                        {
                            Id = 9,
                            Dato = new DateOnly(2024, 03, 21),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Torsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 1
                        },
                        new OpeningHours
                        {
                            Id = 10,
                            Dato = new DateOnly(2024, 03, 22),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Fredag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 2
                        },
                        new OpeningHours
                        {
                            Id = 11,
                            Dato = new DateOnly(2024, 03, 23),
                            OpenString = "08:00-21:00",
                            Weekdays = Entities.Types.Weekdays.Lørdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 2
                        },
                        new OpeningHours
                        {
                            Id = 12,
                            Dato = new DateOnly(2024, 03, 24),
                            OpenString = "Stengt",
                            Weekdays = Entities.Types.Weekdays.Søndag,
                            Closed = true,
                            SpecialOpeningHours = false,
                            StoreId = 2
                        },
                        new OpeningHours
                        {
                            Id = 13,
                            Dato = new DateOnly(2024, 03, 19),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Tirsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 2
                        },
                        new OpeningHours
                        {
                            Id = 14,
                            Dato = new DateOnly(2024, 03, 20),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Onsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 2
                        },
                        new OpeningHours
                        {
                            Id = 15,
                            Dato = new DateOnly(2024, 03, 21),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Torsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 2
                        },
                        new OpeningHours
                        {
                            Id = 16,
                            Dato = new DateOnly(2024, 03, 22),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Fredag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 2
                        },
                        new OpeningHours
                        {
                            Id = 17,
                            Dato = new DateOnly(2024, 03, 23),
                            OpenString = "08:00-21:00",
                            Weekdays = Entities.Types.Weekdays.Lørdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 3
                        },
                        new OpeningHours
                        {
                            Id = 18,
                            Dato = new DateOnly(2024, 03, 24),
                            OpenString = "Stengt",
                            Weekdays = Entities.Types.Weekdays.Søndag,
                            Closed = true,
                            SpecialOpeningHours = false,
                            StoreId = 3
                        },
                        new OpeningHours
                        {
                            Id = 19,
                            Dato = new DateOnly(2024, 03, 19),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Tirsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 3
                        },
                        new OpeningHours
                        {
                            Id = 20,
                            Dato = new DateOnly(2024, 03, 20),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Onsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 3
                        },
                        new OpeningHours
                        {
                            Id = 21,
                            Dato = new DateOnly(2024, 03, 21),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Torsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 3
                        },
                        new OpeningHours
                        {
                            Id = 22,
                            Dato = new DateOnly(2024, 03, 22),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Fredag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 3
                        },
                        new OpeningHours
                        {
                            Id = 23,
                            Dato = new DateOnly(2024, 03, 23),
                            OpenString = "08:00-21:00",
                            Weekdays = Entities.Types.Weekdays.Lørdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 3
                        },
                        new OpeningHours
                        {
                            Id = 24,
                            Dato = new DateOnly(2024, 03, 24),
                            OpenString = "Stengt",
                            Weekdays = Entities.Types.Weekdays.Søndag,
                            Closed = true,
                            SpecialOpeningHours = false,
                            StoreId = 4
                        },
                        new OpeningHours
                        {
                            Id = 25,
                            Dato = new DateOnly(2024, 03, 19),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Tirsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 4
                        },
                        new OpeningHours
                        {
                            Id = 26,
                            Dato = new DateOnly(2024, 03, 20),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Onsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 4
                        },
                        new OpeningHours
                        {
                            Id = 27,
                            Dato = new DateOnly(2024, 03, 21),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Torsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 4
                        },
                        new OpeningHours
                        {
                            Id = 28,
                            Dato = new DateOnly(2024, 03, 22),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Fredag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 4
                        },
                        new OpeningHours
                        {
                            Id = 29,
                            Dato = new DateOnly(2024, 03, 23),
                            OpenString = "08:00-21:00",
                            Weekdays = Entities.Types.Weekdays.Lørdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 4
                        },
                        new OpeningHours
                        {
                            Id = 30,
                            Dato = new DateOnly(2024, 03, 24),
                            OpenString = "Stengt",
                            Weekdays = Entities.Types.Weekdays.Søndag,
                            Closed = true,
                            SpecialOpeningHours = false,
                            StoreId = 4
                        },
                        new OpeningHours
                        {
                            Id = 31,
                            Dato = new DateOnly(2024, 03, 19),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Tirsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 5
                        },
                        new OpeningHours
                        {
                            Id = 32,
                            Dato = new DateOnly(2024, 03, 20),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Onsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 5
                        },
                        new OpeningHours
                        {
                            Id = 33,
                            Dato = new DateOnly(2024, 03, 21),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Torsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 5
                        },
                        new OpeningHours
                        {
                            Id = 34,
                            Dato = new DateOnly(2024, 03, 22),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Fredag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 5
                        },
                        new OpeningHours
                        {
                            Id = 35,
                            Dato = new DateOnly(2024, 03, 23),
                            OpenString = "08:00-21:00",
                            Weekdays = Entities.Types.Weekdays.Lørdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 5
                        },
                        new OpeningHours
                        {
                            Id = 36,
                            Dato = new DateOnly(2024, 03, 24),
                            OpenString = "Stengt",
                            Weekdays = Entities.Types.Weekdays.Søndag,
                            Closed = true,
                            SpecialOpeningHours = false,
                            StoreId = 5
                        },
                        new OpeningHours
                        {
                            Id = 37,
                            Dato = new DateOnly(2024, 03, 19),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Tirsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 5
                        },
                        new OpeningHours
                        {
                            Id = 38,
                            Dato = new DateOnly(2024, 03, 20),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Onsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 6
                        },
                        new OpeningHours
                        {
                            Id = 39,
                            Dato = new DateOnly(2024, 03, 21),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Torsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 6
                        },
                        new OpeningHours
                        {
                            Id = 40,
                            Dato = new DateOnly(2024, 03, 22),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Fredag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 6
                        },
                        new OpeningHours
                        {
                            Id = 41,
                            Dato = new DateOnly(2024, 03, 23),
                            OpenString = "08:00-21:00",
                            Weekdays = Entities.Types.Weekdays.Lørdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 6
                        },
                        new OpeningHours
                        {
                            Id = 42,
                            Dato = new DateOnly(2024, 03, 24),
                            OpenString = "Stengt",
                            Weekdays = Entities.Types.Weekdays.Søndag,
                            Closed = true,
                            SpecialOpeningHours = false,
                            StoreId = 6
                        },
                        new OpeningHours
                        {
                            Id = 43,
                            Dato = new DateOnly(2024, 03, 19),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Tirsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 6
                        },
                        new OpeningHours
                        {
                            Id = 44,
                            Dato = new DateOnly(2024, 03, 20),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Onsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 6
                        },
                        new OpeningHours
                        {
                            Id = 45,
                            Dato = new DateOnly(2024, 03, 21),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Torsdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 7
                        },
                        new OpeningHours
                        {
                            Id = 46,
                            Dato = new DateOnly(2024, 03, 22),
                            OpenString = "07:00-23:00",
                            Weekdays = Entities.Types.Weekdays.Fredag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 7
                        },
                        new OpeningHours
                        {
                            Id = 47,
                            Dato = new DateOnly(2024, 03, 23),
                            OpenString = "08:00-21:00",
                            Weekdays = Entities.Types.Weekdays.Lørdag,
                            Closed = false,
                            SpecialOpeningHours = false,
                            StoreId = 7
                        },
                        new OpeningHours
                        {
                            Id = 48,
                            Dato = new DateOnly(2024, 03, 24),
                            OpenString = "Stengt",
                            Weekdays = Entities.Types.Weekdays.Søndag,
                            Closed = true,
                            SpecialOpeningHours = false,
                            StoreId = 7
                        });


            builder.Entity<Store>().HasData(
                new Store
                {
                    Id = 1,
                    StoreId = 4238,
                    Name = "Tåsen",
                    ChainId = 1,
                    IsEcommerce = false,
                    NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4238",
                    InStoreServiceId = 6,
                    Lat = 59.949938,
                    Lng = 10.749888,
                    OpeningHoursToday = "07:00-23:00",
                    OpenNow = true,
                    Phone = "22237700",
                    Address = "NILS LAURITSSØNSV. 57, 0870 OSLO",
                    City = "Oslo",
                    Distance = 0,
                    Email = "tasen.prix@coop.no",
                    SLag = "NORSK BUTIKKDRIFT AS",
                    OrganizationNumber = "931186744",
                },
                new Store
                {
                    Id = 2,
                    StoreId = 4292,
                    Name = "Ullevål",
                    ChainId = 2,
                    IsEcommerce = false,
                    NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4292",
                    InStoreServiceId = 4,
                    Lat = 59.949938,
                    Lng = 10.7360365,
                    OpeningHoursToday = "07:00-22:00",
                    OpenNow = true,
                    Phone = "22581660",
                    Address = "SOGNSVEIEN 77C, 0855 OSLO",
                    City = "Oslo",
                    Distance = 0,
                    Email = "ulleval.mega@coop.no",
                    SLag = "NORSK BUTIKKDRIFT AS",
                    OrganizationNumber = "931186744",
                },
                new Store
                {
                    Id = 3,
                    StoreId = 4941,
                    Name = "Nydalen",
                    ChainId = 2,
                    IsEcommerce = false,
                    NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4941",
                    InStoreServices = null,
                    Lat = 59.949565,
                    Lng = 10.7657888,
                    OpeningHoursToday = "07:00-23:00",
                    OpenNow = true,
                    Phone = "23260630",
                    Address = "NYDALSVEIEN 33, 0484 OSLO",
                    City = "Oslo",
                    Distance = 0,
                    Email = "nydalen.mega@coop.no",
                    SLag = "NORSK BUTIKKDRIFT AS",
                    OrganizationNumber = "931186744",
                },
                new Store
                {
                    Id = 4,
                    StoreId = 4280,
                    Name = "Bjølsen",
                    ChainId = 3,
                    IsEcommerce = false,
                    NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4280",
                    InStoreServiceId = 2,
                    Lat = 59.9382763,
                    Lng = 10.7571308,
                    OpeningHoursToday = "07:00-23:00",
                    OpenNow = true,
                    Phone = "94176699",
                    Address = "HAMMERGT. 1, 0465 OSLO",
                    City = "Oslo",
                    Distance = 0,
                    Email = "bjolsen.extra@coop.no",
                    SLag = "NORSK BUTIKKDRIFT AS",
                    OrganizationNumber = "931186744",
                },
                new Store
                {
                    Id = 5,
                    StoreId = 4312,
                    Name = "Storo",
                    ChainId = 2,
                    IsEcommerce = false,
                    NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4312",
                    InStoreServices = null,
                    Lat = 59.9468422,
                    Lng = 10.7753876,
                    OpeningHoursToday = "07:00-23:00",
                    OpenNow = true,
                    Phone = "23058080",
                    Address = "VITAMINVEIEN 7/9, 0485 OSLO",
                    City = "Oslo",
                    Distance = 0,
                    Email = "storo.mega@coop.no",
                    SLag = "NORSK BUTIKKDRIFT AS",
                    OrganizationNumber = "931186744",
                },
                new Store
                {
                    Id = 6,
                    StoreId = 1125,
                    Name = "Storo",
                    ChainId = 3,
                    IsEcommerce = false,
                    NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=1125",
                    InStoreServiceId = 7,
                    Lat = 59.9432481,
                    Lng = 10.7738134,
                    OpeningHoursToday = "07:00-23:00",
                    OpenNow = true,
                    Phone = "22222140",
                    Address = "GREFSENVN.26, 0482 OSLO",
                    City = "Oslo",
                    Distance = 0,
                    Email = "storo.extra@coop.no",
                    SLag = "COOP ØST SA",
                    OrganizationNumber = "948432617",
                },
                new Store
                {
                    Id = 7,
                    StoreId = 4226,
                    Name = "Sagene",
                    ChainId = 3,
                    IsEcommerce = false,
                    NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4226",
                    InStoreServiceId = 3,
                    Lat = 59.9355442,
                    Lng = 10.7525795,
                    OpeningHoursToday = "07:00-23:00",
                    OpenNow = true,
                    Phone = "22389370",
                    Address = "THURMANNSGT 12B, 0461 OSLO",
                    City = "Oslo",
                    Distance = 0,
                    Email = "sagene.extra@coop.no",
                    SLag = null,
                    OrganizationNumber = "916510101",
                });
        }
    }
}
