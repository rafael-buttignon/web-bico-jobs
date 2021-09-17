﻿// <auto-generated />
using System;
using Fatec.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fatec.Infrastructure.Migrations
{
    [DbContext(typeof(BicoContext))]
    [Migration("20210917230953_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fatec.Domain.Entities.Address.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.Contract.Contract", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ContractStatusId")
                        .HasColumnType("bigint");

                    b.Property<long>("ContractingUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int?>("Evaluation")
                        .HasColumnType("int");

                    b.Property<long>("JobId")
                        .HasColumnType("bigint");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<long>("RequestId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("TotalDays")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("ContractStatusId");

                    b.HasIndex("ContractingUserId");

                    b.HasIndex("JobId");

                    b.HasIndex("RequestId")
                        .IsUnique();

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.ContractStatus.ContractStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("ContractStatus");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "InProgress"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Concluded"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Cancelled"
                        });
                });

            modelBuilder.Entity("Fatec.Domain.Entities.Job.Job", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan?>("BreakTime")
                        .HasColumnType("time");

                    b.Property<DateTimeOffset?>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<long>("JobCategoryId")
                        .HasColumnType("bigint");

                    b.Property<double>("PriceTime")
                        .HasColumnType("float");

                    b.Property<long>("ProviderId")
                        .HasColumnType("bigint");

                    b.Property<TimeSpan?>("ReturnTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("JobCategoryId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.JobCategory.JobCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("JobCategory");

                    b.HasData(
                        new
                        {
                            Id = 7L,
                            Description = "Construction"
                        },
                        new
                        {
                            Id = 9L,
                            Description = "Domestic"
                        },
                        new
                        {
                            Id = 8L,
                            Description = "Eletric"
                        },
                        new
                        {
                            Id = 11L,
                            Description = "Foods"
                        },
                        new
                        {
                            Id = 12L,
                            Description = "GeneralMaintenance"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "InformationTechnology"
                        },
                        new
                        {
                            Id = 6L,
                            Description = "Logistics"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Management"
                        },
                        new
                        {
                            Id = 5L,
                            Description = "Market"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Medicine"
                        },
                        new
                        {
                            Id = 13L,
                            Description = "Other"
                        },
                        new
                        {
                            Id = 1L,
                            Description = "Pharmacy"
                        },
                        new
                        {
                            Id = 10L,
                            Description = "Plumbing"
                        });
                });

            modelBuilder.Entity("Fatec.Domain.Entities.Request.Request", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("datetime");

                    b.Property<long>("ContractId")
                        .HasColumnType("bigint");

                    b.Property<long>("ContractingUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<long>("JobId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("RejectionDate")
                        .HasColumnType("datetime");

                    b.Property<long>("RequestStatusId")
                        .HasColumnType("bigint");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("ContractingUserId");

                    b.HasIndex("JobId");

                    b.HasIndex("RequestStatusId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.RequestStatus.RequestStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("RequestStatus");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "New"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Rejected"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Approved"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Cancelled"
                        });
                });

            modelBuilder.Entity("Fatec.Domain.Entities.User.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTimeOffset?>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.Address.Address", b =>
                {
                    b.HasOne("Fatec.Domain.Entities.User.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("Fatec.Domain.Entities.Address.Address", "UserId")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.Contract.Contract", b =>
                {
                    b.HasOne("Fatec.Domain.Entities.ContractStatus.ContractStatus", "ContractStatus")
                        .WithMany("Contracts")
                        .HasForeignKey("ContractStatusId")
                        .IsRequired();

                    b.HasOne("Fatec.Domain.Entities.User.User", "ContractingUser")
                        .WithMany("Contracts")
                        .HasForeignKey("ContractingUserId")
                        .IsRequired();

                    b.HasOne("Fatec.Domain.Entities.Job.Job", "Job")
                        .WithMany("Contracts")
                        .HasForeignKey("JobId")
                        .IsRequired();

                    b.HasOne("Fatec.Domain.Entities.Request.Request", "Request")
                        .WithOne("Contract")
                        .HasForeignKey("Fatec.Domain.Entities.Contract.Contract", "RequestId")
                        .IsRequired();

                    b.Navigation("ContractingUser");

                    b.Navigation("ContractStatus");

                    b.Navigation("Job");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.Job.Job", b =>
                {
                    b.HasOne("Fatec.Domain.Entities.JobCategory.JobCategory", "JobCategory")
                        .WithMany("Jobs")
                        .HasForeignKey("JobCategoryId")
                        .IsRequired();

                    b.HasOne("Fatec.Domain.Entities.User.User", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobCategory");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.Request.Request", b =>
                {
                    b.HasOne("Fatec.Domain.Entities.User.User", "ContractingUser")
                        .WithMany("Requests")
                        .HasForeignKey("ContractingUserId")
                        .IsRequired();

                    b.HasOne("Fatec.Domain.Entities.Job.Job", "Job")
                        .WithMany("Requests")
                        .HasForeignKey("JobId")
                        .IsRequired();

                    b.HasOne("Fatec.Domain.Entities.RequestStatus.RequestStatus", "RequestStatus")
                        .WithMany("Requests")
                        .HasForeignKey("RequestStatusId")
                        .IsRequired();

                    b.Navigation("ContractingUser");

                    b.Navigation("Job");

                    b.Navigation("RequestStatus");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.ContractStatus.ContractStatus", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.Job.Job", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.JobCategory.JobCategory", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.Request.Request", b =>
                {
                    b.Navigation("Contract");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.RequestStatus.RequestStatus", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Fatec.Domain.Entities.User.User", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Contracts");

                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
