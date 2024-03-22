﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ButikkKatalogContext))]
    partial class ButikkKatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Entities.ChainInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Chain")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChainClassName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChainImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChainNr")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ChainInfo", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Chain = "Prix",
                            ChainClassName = "prix",
                            ChainImage = "/assets/images/mapmarkers/01.png?7003341bcfe337a104c5a8ee79251d4d",
                            ChainNr = "01"
                        },
                        new
                        {
                            Id = 2,
                            Chain = "Mega",
                            ChainClassName = "mega",
                            ChainImage = "/assets/images/mapmarkers/03.png?d7b089ef57ad29e69c3520f42bc8aae1",
                            ChainNr = "03"
                        },
                        new
                        {
                            Id = 3,
                            Chain = "Extra",
                            ChainClassName = "extra",
                            ChainImage = "/assets/images/mapmarkers/07.png?938d3bb66e14f3c8dd9fc5b45feb4fce",
                            ChainNr = "07"
                        });
                });

            modelBuilder.Entity("Entities.InStoreServices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("MemberOffer")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Post")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Postnord")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StoreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("InStoreServices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MemberOffer = true,
                            Post = false,
                            Postnord = true
                        },
                        new
                        {
                            Id = 2,
                            MemberOffer = true,
                            Post = false,
                            Postnord = true
                        },
                        new
                        {
                            Id = 3,
                            MemberOffer = true,
                            Post = false,
                            Postnord = true
                        },
                        new
                        {
                            Id = 4,
                            MemberOffer = true,
                            Post = false,
                            Postnord = true
                        },
                        new
                        {
                            Id = 5,
                            MemberOffer = true,
                            Post = false,
                            Postnord = true
                        },
                        new
                        {
                            Id = 6,
                            MemberOffer = true,
                            Post = false,
                            Postnord = true
                        },
                        new
                        {
                            Id = 7,
                            MemberOffer = true,
                            Post = false,
                            Postnord = true
                        });
                });

            modelBuilder.Entity("Entities.OpeningHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Closed")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Dato")
                        .HasColumnType("TEXT");

                    b.Property<string>("OpenString")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SpecialOpeningHours")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StoreId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weekdays")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("OpeningHours", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 19),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 7,
                            Weekdays = 1
                        },
                        new
                        {
                            Id = 2,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 20),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 1,
                            Weekdays = 2
                        },
                        new
                        {
                            Id = 3,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 21),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 1,
                            Weekdays = 3
                        },
                        new
                        {
                            Id = 4,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 22),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 1,
                            Weekdays = 4
                        },
                        new
                        {
                            Id = 5,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 23),
                            OpenString = "08:00-21:00",
                            SpecialOpeningHours = false,
                            StoreId = 1,
                            Weekdays = 5
                        },
                        new
                        {
                            Id = 6,
                            Closed = true,
                            Dato = new DateOnly(2024, 3, 24),
                            OpenString = "Stengt",
                            SpecialOpeningHours = false,
                            StoreId = 1,
                            Weekdays = 6
                        },
                        new
                        {
                            Id = 7,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 19),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 1,
                            Weekdays = 1
                        },
                        new
                        {
                            Id = 8,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 20),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 1,
                            Weekdays = 2
                        },
                        new
                        {
                            Id = 9,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 21),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 1,
                            Weekdays = 3
                        },
                        new
                        {
                            Id = 10,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 22),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 2,
                            Weekdays = 4
                        },
                        new
                        {
                            Id = 11,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 23),
                            OpenString = "08:00-21:00",
                            SpecialOpeningHours = false,
                            StoreId = 2,
                            Weekdays = 5
                        },
                        new
                        {
                            Id = 12,
                            Closed = true,
                            Dato = new DateOnly(2024, 3, 24),
                            OpenString = "Stengt",
                            SpecialOpeningHours = false,
                            StoreId = 2,
                            Weekdays = 6
                        },
                        new
                        {
                            Id = 13,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 19),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 2,
                            Weekdays = 1
                        },
                        new
                        {
                            Id = 14,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 20),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 2,
                            Weekdays = 2
                        },
                        new
                        {
                            Id = 15,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 21),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 2,
                            Weekdays = 3
                        },
                        new
                        {
                            Id = 16,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 22),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 2,
                            Weekdays = 4
                        },
                        new
                        {
                            Id = 17,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 23),
                            OpenString = "08:00-21:00",
                            SpecialOpeningHours = false,
                            StoreId = 3,
                            Weekdays = 5
                        },
                        new
                        {
                            Id = 18,
                            Closed = true,
                            Dato = new DateOnly(2024, 3, 24),
                            OpenString = "Stengt",
                            SpecialOpeningHours = false,
                            StoreId = 3,
                            Weekdays = 6
                        },
                        new
                        {
                            Id = 19,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 19),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 3,
                            Weekdays = 1
                        },
                        new
                        {
                            Id = 20,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 20),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 3,
                            Weekdays = 2
                        },
                        new
                        {
                            Id = 21,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 21),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 3,
                            Weekdays = 3
                        },
                        new
                        {
                            Id = 22,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 22),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 3,
                            Weekdays = 4
                        },
                        new
                        {
                            Id = 23,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 23),
                            OpenString = "08:00-21:00",
                            SpecialOpeningHours = false,
                            StoreId = 3,
                            Weekdays = 5
                        },
                        new
                        {
                            Id = 24,
                            Closed = true,
                            Dato = new DateOnly(2024, 3, 24),
                            OpenString = "Stengt",
                            SpecialOpeningHours = false,
                            StoreId = 4,
                            Weekdays = 6
                        },
                        new
                        {
                            Id = 25,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 19),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 4,
                            Weekdays = 1
                        },
                        new
                        {
                            Id = 26,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 20),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 4,
                            Weekdays = 2
                        },
                        new
                        {
                            Id = 27,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 21),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 4,
                            Weekdays = 3
                        },
                        new
                        {
                            Id = 28,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 22),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 4,
                            Weekdays = 4
                        },
                        new
                        {
                            Id = 29,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 23),
                            OpenString = "08:00-21:00",
                            SpecialOpeningHours = false,
                            StoreId = 4,
                            Weekdays = 5
                        },
                        new
                        {
                            Id = 30,
                            Closed = true,
                            Dato = new DateOnly(2024, 3, 24),
                            OpenString = "Stengt",
                            SpecialOpeningHours = false,
                            StoreId = 4,
                            Weekdays = 6
                        },
                        new
                        {
                            Id = 31,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 19),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 5,
                            Weekdays = 1
                        },
                        new
                        {
                            Id = 32,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 20),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 5,
                            Weekdays = 2
                        },
                        new
                        {
                            Id = 33,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 21),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 5,
                            Weekdays = 3
                        },
                        new
                        {
                            Id = 34,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 22),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 5,
                            Weekdays = 4
                        },
                        new
                        {
                            Id = 35,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 23),
                            OpenString = "08:00-21:00",
                            SpecialOpeningHours = false,
                            StoreId = 5,
                            Weekdays = 5
                        },
                        new
                        {
                            Id = 36,
                            Closed = true,
                            Dato = new DateOnly(2024, 3, 24),
                            OpenString = "Stengt",
                            SpecialOpeningHours = false,
                            StoreId = 5,
                            Weekdays = 6
                        },
                        new
                        {
                            Id = 37,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 19),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 5,
                            Weekdays = 1
                        },
                        new
                        {
                            Id = 38,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 20),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 6,
                            Weekdays = 2
                        },
                        new
                        {
                            Id = 39,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 21),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 6,
                            Weekdays = 3
                        },
                        new
                        {
                            Id = 40,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 22),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 6,
                            Weekdays = 4
                        },
                        new
                        {
                            Id = 41,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 23),
                            OpenString = "08:00-21:00",
                            SpecialOpeningHours = false,
                            StoreId = 6,
                            Weekdays = 5
                        },
                        new
                        {
                            Id = 42,
                            Closed = true,
                            Dato = new DateOnly(2024, 3, 24),
                            OpenString = "Stengt",
                            SpecialOpeningHours = false,
                            StoreId = 6,
                            Weekdays = 6
                        },
                        new
                        {
                            Id = 43,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 19),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 6,
                            Weekdays = 1
                        },
                        new
                        {
                            Id = 44,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 20),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 6,
                            Weekdays = 2
                        },
                        new
                        {
                            Id = 45,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 21),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 7,
                            Weekdays = 3
                        },
                        new
                        {
                            Id = 46,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 22),
                            OpenString = "07:00-23:00",
                            SpecialOpeningHours = false,
                            StoreId = 7,
                            Weekdays = 4
                        },
                        new
                        {
                            Id = 47,
                            Closed = false,
                            Dato = new DateOnly(2024, 3, 23),
                            OpenString = "08:00-21:00",
                            SpecialOpeningHours = false,
                            StoreId = 7,
                            Weekdays = 5
                        },
                        new
                        {
                            Id = 48,
                            Closed = true,
                            Dato = new DateOnly(2024, 3, 24),
                            OpenString = "Stengt",
                            SpecialOpeningHours = false,
                            StoreId = 7,
                            Weekdays = 6
                        });
                });

            modelBuilder.Entity("Entities.OpeningHoursSpecial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Closed")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Dato")
                        .HasColumnType("TEXT");

                    b.Property<string>("OpenString")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SpecialOpeningHours")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StoreId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weekdays")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("OpeningHoursSpecial", (string)null);
                });

            modelBuilder.Entity("Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChainId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChainInfoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<int>("Distance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("InStoreServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEcommerce")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Lat")
                        .HasColumnType("REAL");

                    b.Property<double>("Lng")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NewspaperUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("OpenNow")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OpeningHoursId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OpeningHoursToday")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("SLag")
                        .HasColumnType("TEXT");

                    b.Property<int>("StoreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChainInfoId");

                    b.ToTable("Store", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "NILS LAURITSSØNSV. 57, 0870 OSLO",
                            ChainId = 1,
                            City = "Oslo",
                            Distance = 0,
                            Email = "tasen.prix@coop.no",
                            InStoreServiceId = 6,
                            IsEcommerce = false,
                            Lat = 59.949938000000003,
                            Lng = 10.749888,
                            Name = "Tåsen",
                            NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4238",
                            OpenNow = true,
                            OpeningHoursId = 0,
                            OpeningHoursToday = "07:00-23:00",
                            OrganizationNumber = "931186744",
                            Phone = "22237700",
                            SLag = "NORSK BUTIKKDRIFT AS",
                            StoreId = 4238
                        },
                        new
                        {
                            Id = 2,
                            Address = "SOGNSVEIEN 77C, 0855 OSLO",
                            ChainId = 2,
                            City = "Oslo",
                            Distance = 0,
                            Email = "ulleval.mega@coop.no",
                            InStoreServiceId = 4,
                            IsEcommerce = false,
                            Lat = 59.949938000000003,
                            Lng = 10.736036500000001,
                            Name = "Ullevål",
                            NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4292",
                            OpenNow = true,
                            OpeningHoursId = 0,
                            OpeningHoursToday = "07:00-22:00",
                            OrganizationNumber = "931186744",
                            Phone = "22581660",
                            SLag = "NORSK BUTIKKDRIFT AS",
                            StoreId = 4292
                        },
                        new
                        {
                            Id = 3,
                            Address = "NYDALSVEIEN 33, 0484 OSLO",
                            ChainId = 2,
                            City = "Oslo",
                            Distance = 0,
                            Email = "nydalen.mega@coop.no",
                            InStoreServiceId = 0,
                            IsEcommerce = false,
                            Lat = 59.949565,
                            Lng = 10.765788799999999,
                            Name = "Nydalen",
                            NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4941",
                            OpenNow = true,
                            OpeningHoursId = 0,
                            OpeningHoursToday = "07:00-23:00",
                            OrganizationNumber = "931186744",
                            Phone = "23260630",
                            SLag = "NORSK BUTIKKDRIFT AS",
                            StoreId = 4941
                        },
                        new
                        {
                            Id = 4,
                            Address = "HAMMERGT. 1, 0465 OSLO",
                            ChainId = 3,
                            City = "Oslo",
                            Distance = 0,
                            Email = "bjolsen.extra@coop.no",
                            InStoreServiceId = 2,
                            IsEcommerce = false,
                            Lat = 59.938276299999998,
                            Lng = 10.757130800000001,
                            Name = "Bjølsen",
                            NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4280",
                            OpenNow = true,
                            OpeningHoursId = 0,
                            OpeningHoursToday = "07:00-23:00",
                            OrganizationNumber = "931186744",
                            Phone = "94176699",
                            SLag = "NORSK BUTIKKDRIFT AS",
                            StoreId = 4280
                        },
                        new
                        {
                            Id = 5,
                            Address = "VITAMINVEIEN 7/9, 0485 OSLO",
                            ChainId = 2,
                            City = "Oslo",
                            Distance = 0,
                            Email = "storo.mega@coop.no",
                            InStoreServiceId = 0,
                            IsEcommerce = false,
                            Lat = 59.946842199999999,
                            Lng = 10.7753876,
                            Name = "Storo",
                            NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4312",
                            OpenNow = true,
                            OpeningHoursId = 0,
                            OpeningHoursToday = "07:00-23:00",
                            OrganizationNumber = "931186744",
                            Phone = "23058080",
                            SLag = "NORSK BUTIKKDRIFT AS",
                            StoreId = 4312
                        },
                        new
                        {
                            Id = 6,
                            Address = "GREFSENVN.26, 0482 OSLO",
                            ChainId = 3,
                            City = "Oslo",
                            Distance = 0,
                            Email = "storo.extra@coop.no",
                            InStoreServiceId = 7,
                            IsEcommerce = false,
                            Lat = 59.943248099999998,
                            Lng = 10.7738134,
                            Name = "Storo",
                            NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=1125",
                            OpenNow = true,
                            OpeningHoursId = 0,
                            OpeningHoursToday = "07:00-23:00",
                            OrganizationNumber = "948432617",
                            Phone = "22222140",
                            SLag = "COOP ØST SA",
                            StoreId = 1125
                        },
                        new
                        {
                            Id = 7,
                            Address = "THURMANNSGT 12B, 0461 OSLO",
                            ChainId = 3,
                            City = "Oslo",
                            Distance = 0,
                            Email = "sagene.extra@coop.no",
                            InStoreServiceId = 3,
                            IsEcommerce = false,
                            Lat = 59.935544200000002,
                            Lng = 10.7525795,
                            Name = "Sagene",
                            NewspaperUrl = "http://kundeavis.coop.no/aviser/?id=4226",
                            OpenNow = true,
                            OpeningHoursId = 0,
                            OpeningHoursToday = "07:00-23:00",
                            OrganizationNumber = "916510101",
                            Phone = "22389370",
                            StoreId = 4226
                        });
                });

            modelBuilder.Entity("Entities.InStoreServices", b =>
                {
                    b.HasOne("Entities.Store", null)
                        .WithMany("InStoreServices")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("Entities.OpeningHours", b =>
                {
                    b.HasOne("Entities.Store", null)
                        .WithMany("OpeningHours")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Store", b =>
                {
                    b.HasOne("Entities.ChainInfo", "ChainInfo")
                        .WithMany()
                        .HasForeignKey("ChainInfoId");

                    b.Navigation("ChainInfo");
                });

            modelBuilder.Entity("Entities.Store", b =>
                {
                    b.Navigation("InStoreServices");

                    b.Navigation("OpeningHours");
                });
#pragma warning restore 612, 618
        }
    }
}
