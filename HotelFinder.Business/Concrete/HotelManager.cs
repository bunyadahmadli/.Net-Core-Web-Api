using System;
using System.Collections.Generic;
using System.Text;
using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;

namespace HotelFinder.Business.Concrete
{
   public class HotelManager:IHotelService
   {
       private IHotelRepository _hotelRepository;

       public HotelManager()
       {
           _hotelRepository = new HotelRepository();
       }

       public List<Hotel> GetAllHotels()
       {
           return _hotelRepository.GetAllHotels();
       }

        public Hotel GetHotelById(int id)
        {
            if (id>0)
            {
           return _hotelRepository.GetHotelById(id);

            }
            throw new Exception("id can not be less than 1");
        }

        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
           _hotelRepository.DeleteHotel(id);
        }
    }
}
