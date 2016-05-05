using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(TripContext))]
    [Migration("20160428181237_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Stop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<double>("LongLat");

                    b.Property<string>("Name");

                    b.Property<string>("Order");

                    b.Property<int?>("TripID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("WebApplication1.Models.Trip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.Property<string>("UserName");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("WebApplication1.Models.Stop", b =>
                {
                    b.HasOne("WebApplication1.Models.Trip")
                        .WithMany()
                        .HasForeignKey("TripID");
                });
        }
    }
}
