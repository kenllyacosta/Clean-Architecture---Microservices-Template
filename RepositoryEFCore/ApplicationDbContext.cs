﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RepositoryEFCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products {  get; set;}
        public virtual DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategorySalesFor1997> CategorySalesFor1997s { get; set; }
        public virtual DbSet<CurrentProductList> CurrentProductLists { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        public virtual DbSet<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
        public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        public virtual DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        public virtual DbSet<OrdersQry> OrdersQries { get; set; }        
        public virtual DbSet<ProductSalesFor1997> ProductSalesFor1997s { get; set; }
        public virtual DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        public virtual DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        public virtual DbSet<QuarterlyOrder> QuarterlyOrders { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<SalesByCategory> SalesByCategories { get; set; }
        public virtual DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        public virtual DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }

        //Esta clase la agregamos para ejecutar las migraciones de Entity Framework Core
        /// <summary>
        /// 1. Instalar Microsoft.EntityFrameworkCore.Tools
        /// 2. Add-Migration NombreDeLaMigración -s Repository.EFCore -p Repository.EFCore -c ApplicationDbcontext -o Data\Migrations
        /// 3. Update-Database -s Repository.EFCore -p Repository.EFCore
        /// </summary>
        public class AplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        {
            public ApplicationDbContext CreateDbContext(string[] args)
            {
                var OptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

                OptionsBuilder.UseSqlServer("Data Source = .;Initial Catalog = Northwind; Integrated Security = True;");

                return new ApplicationDbContext(OptionsBuilder.Options);
            }
        }
    }
}
