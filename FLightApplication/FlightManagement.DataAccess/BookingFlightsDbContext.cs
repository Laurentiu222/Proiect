﻿using FlightManagement.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.DataAccess
{
    public class BookingFlightsDbContext : DbContext
    {
        public BookingFlightsDbContext(DbContextOptions<BookingFlightsDbContext> dbContext) : base(dbContext) { }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Flight> Flights { get; set; }
        
        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<TIcket> TIckets { get; set; }
    }
}
