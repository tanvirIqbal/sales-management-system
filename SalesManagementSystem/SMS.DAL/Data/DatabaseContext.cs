﻿using Microsoft.EntityFrameworkCore;
using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static SMS.Shared.Enums;

namespace SMS.DAL.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Window> Windows { get; set; }
        public DbSet<SubElement> SubElements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SubElement>().Ignore(o => o.IsDeleted);
            modelBuilder.Entity<Window>().Ignore(o => o.IsDeleted);

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = 1,
                Name = "New York Building 1",
                State = StateCode.NY
            });
            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = 2,
                Name = "California Hotel AJK",
                State = StateCode.CA
            });
            // For order: 1
            modelBuilder.Entity<Window>().HasData(new Window
            {
                Id = 1,
                Name = "A51",
                QuantityOfWindows = 4,
                TotalSubElements = 3,
                OrderId = 1
            });
            modelBuilder.Entity<Window>().HasData(new Window
            {
                Id = 2,
                Name = "C Zone 5",
                QuantityOfWindows = 2,
                TotalSubElements = 1,
                OrderId = 1
            });

            // For order: 2
            modelBuilder.Entity<Window>().HasData(new Window
            {
                Id = 3,
                Name = "GLB",
                QuantityOfWindows = 3,
                TotalSubElements = 2,
                OrderId = 2
            });
            modelBuilder.Entity<Window>().HasData(new Window
            {
                Id = 4,
                Name = "OHF",
                QuantityOfWindows = 10,
                TotalSubElements = 2,
                OrderId = 2
            });

            // For window: 1
            modelBuilder.Entity<SubElement>().HasData(new SubElement
            {
                Id = 1,
                Element = 1,
                Type = ElementType.Doors,
                Width = 1200,
                Height = 1850,
                WindowId = 1
            });
            modelBuilder.Entity<SubElement>().HasData(new SubElement
            {
                Id = 2,
                Element = 2,
                Type = ElementType.Window,
                Width = 800,
                Height = 1850,
                WindowId = 1
            });
            modelBuilder.Entity<SubElement>().HasData(new SubElement
            {
                Id = 3,
                Element = 3,
                Type = ElementType.Window,
                Width = 700,
                Height = 1850,
                WindowId = 1
            });

            // For window: 2
            modelBuilder.Entity<SubElement>().HasData(new SubElement
            {
                Id = 4,
                Element = 1,
                Type = ElementType.Window,
                Width = 1500,
                Height = 2000,
                WindowId = 2
            });

            // For window: 3
            modelBuilder.Entity<SubElement>().HasData(new SubElement
            {
                Id = 5,
                Element = 1,
                Type = ElementType.Doors,
                Width = 1400,
                Height = 2200,
                WindowId = 3
            });
            modelBuilder.Entity<SubElement>().HasData(new SubElement
            {
                Id = 6,
                Element = 2,
                Type = ElementType.Window,
                Width = 600,
                Height = 2200,
                WindowId = 3
            });


            // For window: 4
            modelBuilder.Entity<SubElement>().HasData(new SubElement
            {
                Id = 7,
                Element = 1,
                Type = ElementType.Window,
                Width = 1500,
                Height = 2000,
                WindowId = 4
            });
            modelBuilder.Entity<SubElement>().HasData(new SubElement
            {
                Id = 8,
                Element = 1,
                Type = ElementType.Window,
                Width = 1500,
                Height = 2000,
                WindowId = 4
            });
        }
    }
}
