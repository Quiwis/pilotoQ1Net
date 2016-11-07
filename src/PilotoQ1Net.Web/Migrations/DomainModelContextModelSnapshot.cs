using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PilotoQ1Net.DataAccess;

namespace PilotoQ1Net.Web.Migrations
{
    [DbContext(typeof(DomainModelContext))]
    partial class DomainModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 400);

                    b.Property<DateTime>("ExpiredDate");

                    b.Property<bool>("Global");

                    b.Property<string>("Image")
                        .HasAnnotation("MaxLength", 4000);

                    b.Property<int?>("ProfileId")
                        .IsRequired();

                    b.Property<DateTime>("StartedDate");

                    b.Property<string>("TextAlign")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Tittle")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<DateTime>("Updated");

                    b.Property<int?>("createById")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("createById");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.OrganizationalUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("OrganizationalUnit");
                });

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.Permision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int?>("ProfileId");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Permision");
                });

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<DateTime>("Updated");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<int?>("ContentId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("EmployeeCode")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<int>("JobIdId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<int>("OrganizationalUnitIdId");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<DateTime>("StartCompanyDate");

                    b.Property<bool>("StatusUser");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("JobIdId");

                    b.HasIndex("OrganizationalUnitIdId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.Content", b =>
                {
                    b.HasOne("PilotoQ1Net.Models.Dtos.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PilotoQ1Net.Models.Dtos.User", "createBy")
                        .WithMany()
                        .HasForeignKey("createById")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.Permision", b =>
                {
                    b.HasOne("PilotoQ1Net.Models.Dtos.Profile")
                        .WithMany("Permisions")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.Profile", b =>
                {
                    b.HasOne("PilotoQ1Net.Models.Dtos.User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PilotoQ1Net.Models.Dtos.User", b =>
                {
                    b.HasOne("PilotoQ1Net.Models.Dtos.Content")
                        .WithMany("UserIds")
                        .HasForeignKey("ContentId");

                    b.HasOne("PilotoQ1Net.Models.Dtos.Job", "JobId")
                        .WithMany()
                        .HasForeignKey("JobIdId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PilotoQ1Net.Models.Dtos.OrganizationalUnit", "OrganizationalUnitId")
                        .WithMany()
                        .HasForeignKey("OrganizationalUnitIdId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
