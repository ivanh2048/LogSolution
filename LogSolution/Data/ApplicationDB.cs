using LogSolution.Models;
using System.Collections.Generic;

namespace LogSolution.Base
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Zarządzanie klientami
        public DbSet<Customer> Customers { get; set; }

        // Zarządzanie zamówieniami i wysyłkami
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        // Zarządzanie magazynami
        public DbSet<Warehouse> Warehouses { get; set; }

        // Zarządzanie pracownikami i grafikami
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSchedule> EmployeeSchedules { get; set; }

        // System premiowy
        public DbSet<Bonus> Bonuses { get; set; }

        // Raporty i analizy
        public DbSet<Report> Reports { get; set; }

        // Użytkownicy systemu i role
        public DbSet<SystemUser> SystemUsers { get; set; } // jeśli oddzielnie od Employee

        // Partnerzy zewnętrzni
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<TransportCompany> TransportCompanies { get; set; }

        // Dla historii logowań, akcji, synchronizacji itd. (opcjonalnie)
        public DbSet<IntegrationLog> IntegrationLogs { get; set; }
    }

}
