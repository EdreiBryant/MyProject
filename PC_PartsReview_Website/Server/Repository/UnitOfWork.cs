﻿using PC_PartsReview_Website.Server.Data;
using PC_PartsReview_Website.Server.IRepository;
using PC_PartsReview_Website.Server.Models;
using PC_PartsReview_Website.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PC_PartsReview_Website.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        //private IGenericRepository<Make> _makes;
        //private IGenericRepository<Model> _models;
        //private IGenericRepository<Colour> _colours;
        //private IGenericRepository<Booking> _bookings;
        //private IGenericRepository<Customer> _customers;
        //private IGenericRepository<Vehicle> _vehicles;

        private IGenericRepository<Rating> _ratings;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<PcPart> _pcparts;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        //public IGenericRepository<Make> Makes
        //    => _makes ??= new GenericRepository<Make>(_context);
        //public IGenericRepository<Model> Models
        //    => _models ??= new GenericRepository<Model>(_context);
        //public IGenericRepository<Colour> Colours
        //    => _colours ??= new GenericRepository<Colour>(_context);
        //public IGenericRepository<Vehicle> Vehicles
        //    => _vehicles ??= new GenericRepository<Vehicle>(_context);
        //public IGenericRepository<Booking> Bookings
        //    => _bookings ??= new GenericRepository<Booking>(_context);
        //public IGenericRepository<Customer> Customers
        //    => _customers ??= new GenericRepository<Customer>(_context);

        public IGenericRepository<Rating> Ratings
            => _ratings ??= new GenericRepository<Rating>(_context);
        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<PcPart> PcParts
            => _pcparts ??= new GenericRepository<PcPart>(_context);



        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}