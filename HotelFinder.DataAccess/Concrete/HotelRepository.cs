﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;

namespace HotelFinder.DataAccess.Concrete
{
   public class HotelRepository:IHotelRepository
    {
        public List<Hotel> GetAllHotels()
        {
            using (var hotelDbContext =new HotelDbContext())
            {
                return hotelDbContext.Hotels.ToList();
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.Find(id);
            }
        }

        public Hotel CreateHotel(Hotel hotel)
        {
            using (var hotelDbContext =new HotelDbContext())
            {
                hotelDbContext.Hotels.Add(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }
            
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (var hotelDbContext =new HotelDbContext())
            {
                hotelDbContext.Hotels.Update(hotel);
                return hotel;
            }
        }

        public void DeleteHotel(int id)
        {
            using (var hotelDbContext=new HotelDbContext())
            {
                var deletedHotel = GetHotelById(id);
                hotelDbContext.Hotels.Remove(deletedHotel);
                hotelDbContext.SaveChanges();
            }
        }
    }
}
