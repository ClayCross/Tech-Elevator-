using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelDao hotelDao;
        private IReservationDao reservationDao;

        public HotelsController()
        {
            hotelDao = new HotelFakeDao();
            reservationDao = new ReservationFakeDao();
        }

        [HttpGet("hotels")]
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public Hotel GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }

            return null;
        }

        [HttpGet("hotels/{hotelid}/reservations")]
        public List<Reservation> GetReservations(int hotelId)
        {
            return reservationDao.FindByHotel(hotelId);
        }
        // create a new reservation
        [HttpPost("reservations")]

        public ActionResult<Reservation> CreateReservation(Reservation newRes)
        {
            Reservation res = reservationDao.Create(newRes);

            return Created($/ GetReservations /{ res.Id})
             
        }
    }
}
