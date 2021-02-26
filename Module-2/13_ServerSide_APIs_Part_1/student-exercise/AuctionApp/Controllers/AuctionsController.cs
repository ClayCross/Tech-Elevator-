using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }
        [HttpGet("/auctions")]
        public List<Auction> GetAllAuctions(string title_like = "")

        {
            if ( title_like == "" ){
                return dao.List();
            }
            else
            {
                 return dao.SearchByTitle(title_like);
            }
        }

        [HttpGet("/auctions/{id}")]
        public Auction GetAuction(int id)
        {
            Auction auction = dao.Get(id);

            if (auction != null)
            {
                return auction;
            }

            return null;
        }

        [HttpPost("/auctions")]
        public ActionResult<Auction> CreateReservation(Auction newAuction)
        {
            Auction auction = dao.Create(newAuction);

            return Created($"/auctions/{auction.Id }", auction);
        }

    }
}
