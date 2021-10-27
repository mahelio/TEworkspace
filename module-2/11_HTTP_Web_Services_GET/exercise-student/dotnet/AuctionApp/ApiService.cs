using RestSharp;
using System.Collections.Generic;
using AuctionApp.Models;

namespace AuctionApp
{
    public class ApiService
    {
        public const string API_URL = "http://localhost:3000/auctions";
        public IRestClient client = new RestClient();

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(API_URL);
            IRestResponse<List<Auction>> auctions = client.Get<List<Auction>>(request);
            return auctions.Data;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest request = new RestRequest(API_URL + $"/{auctionId}");
            IRestResponse<Auction> auctions = client.Get<Auction>(request);
            return auctions.Data;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(API_URL + $"?title_like={searchTitle}");
            IRestResponse<List<Auction>> auctions = client.Get<List<Auction>>(request);
            return auctions.Data;

        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(API_URL + $"?currentBid_lte={searchPrice}");
            IRestResponse<List<Auction>> auctions = client.Get<List<Auction>>(request);
            return auctions.Data;
        }
    }
}
