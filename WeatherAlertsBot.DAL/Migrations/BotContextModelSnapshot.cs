﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherAlertsBot.DAL.Context;

#nullable disable

namespace WeatherAlertsBot.DAL.Migrations
{
    [DbContext(typeof(BotContext))]
    partial class BotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CommandSubsrciber", b =>
                {
                    b.Property<int>("CommandsId")
                        .HasColumnType("int");

                    b.Property<long>("SubsrciberChatId")
                        .HasColumnType("bigint");

                    b.HasKey("CommandsId", "SubsrciberChatId");

                    b.HasIndex("SubsrciberChatId");

                    b.ToTable("CommandSubsrciber");
                });

            modelBuilder.Entity("WeatherAlertsBot.DAL.Entities.Command", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommandName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Commands");
                });

            modelBuilder.Entity("WeatherAlertsBot.DAL.Entities.Subsrciber", b =>
                {
                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.HasKey("ChatId");

                    b.ToTable("Subsrcibers");
                });

            modelBuilder.Entity("CommandSubsrciber", b =>
                {
                    b.HasOne("WeatherAlertsBot.DAL.Entities.Command", null)
                        .WithMany()
                        .HasForeignKey("CommandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeatherAlertsBot.DAL.Entities.Subsrciber", null)
                        .WithMany()
                        .HasForeignKey("SubsrciberChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
