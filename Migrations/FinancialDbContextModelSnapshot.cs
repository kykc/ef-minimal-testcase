﻿// <auto-generated />
using efc_minimal_testcase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace efcminimaltestcase.Migrations
{
    [DbContext(typeof(FinancialDbContext))]
    partial class FinancialDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("efc_minimal_testcase.BusinessTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("BusinessTransactions");
                });

            modelBuilder.Entity("efc_minimal_testcase.BusinessTransaction", b =>
                {
                    b.OwnsOne("efc_minimal_testcase.MoneyAmount", "AmountCharged", b1 =>
                        {
                            b1.Property<int?>("BusinessTransactionId");

                            b1.Property<decimal>("Amount");

                            b1.Property<int>("Currency");

                            b1.ToTable("BusinessTransactions");

                            b1.HasOne("efc_minimal_testcase.BusinessTransaction")
                                .WithOne("AmountCharged")
                                .HasForeignKey("efc_minimal_testcase.MoneyAmount", "BusinessTransactionId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("efc_minimal_testcase.MoneyAmount", "Profit", b1 =>
                        {
                            b1.Property<int>("BusinessTransactionId");

                            b1.Property<decimal>("Amount");

                            b1.Property<int>("Currency");

                            b1.ToTable("BusinessTransactions");

                            b1.HasOne("efc_minimal_testcase.BusinessTransaction")
                                .WithOne("Profit")
                                .HasForeignKey("efc_minimal_testcase.MoneyAmount", "BusinessTransactionId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}