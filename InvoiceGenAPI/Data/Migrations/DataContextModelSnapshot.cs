﻿// <auto-generated />
using System;
using InvoiceGenAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvoiceGenAPI.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("InvoiceGenAPI.Entities.CustomField", b =>
                {
                    b.Property<int>("CustomFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Label")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomFieldId");

                    b.ToTable("CustomFields");
                });

            modelBuilder.Entity("InvoiceGenAPI.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AllowPartialPayment")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("GSTNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InvoiceGenAPI.Entities.CustomerContactPerson", b =>
                {
                    b.Property<int>("CustomerContactPersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContactCustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CustomerContactPersonId");

                    b.ToTable("CustomerContact");
                });

            modelBuilder.Entity("InvoiceGenAPI.Entities.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discount")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DiscountBeforeTax")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GstTreatment")
                        .HasColumnType("TEXT");

                    b.Property<string>("InvoiceNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentTerms")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlaceOfSupply")
                        .HasColumnType("TEXT");

                    b.Property<string>("Salesman")
                        .HasColumnType("TEXT");

                    b.Property<float>("ShippingCharge")
                        .HasColumnType("REAL");

                    b.Property<string>("Terms")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("InvoiceGenAPI.Entities.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductType")
                        .HasColumnType("TEXT");

                    b.Property<float>("Rate")
                        .HasColumnType("REAL");

                    b.Property<float>("TaxPercent")
                        .HasColumnType("REAL");

                    b.Property<string>("TaxType")
                        .HasColumnType("TEXT");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("InvoiceGenAPI.Entities.LineItems", b =>
                {
                    b.Property<int>("LineItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discount")
                        .HasColumnType("TEXT");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Itemtotal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineItemsId");

                    b.ToTable("lineItems");
                });

            modelBuilder.Entity("InvoiceGenAPI.Entities.PaymentGateway", b =>
                {
                    b.Property<int>("PaymentGatewayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Additional_field")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Configured")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gateway_name")
                        .HasColumnType("TEXT");

                    b.HasKey("PaymentGatewayId");

                    b.ToTable("Paymentgateway");
                });
#pragma warning restore 612, 618
        }
    }
}
