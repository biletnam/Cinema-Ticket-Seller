﻿using CinemaTickets.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaTickets.DataModel.Models;
using CinemaTickets.DataModel;

namespace CinemaTickets.Services
{
    public class ImageService : IImageService
    {
        private CinemaTicketsDbContext _context;
        public ImageService()
        {
            this._context = new CinemaTicketsDbContext();
        }
        public void AddImage(Image image)
        {
            this._context.Images.Add(image);
            this._context.SaveChanges();
        }

        public Image GetImage(int id)
        {
            return this._context.Images.FirstOrDefault(image => image.ImageID == id);
        }
    }
}