using System;
using GameProjectHomework.Concrete;
using GameProjectHomework.Entities;

namespace GameProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game Project by Hasret Kalhan 02.02.2021");
            
            Console.WriteLine("Select User Validation Service");


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Hasret", LastName = "Kalhan", BirthYear = 1999, IdentityNumber = 11111111111 });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Id = 1, CampaignName = "Winter Discount", CampaignDetails = "20 % discount on shopping cart" });

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Buy(new GameSale { Id = 1, GameName = "PUBG", GamePrice = 250 }, new Gamer { FirstName = "Hasret", LastName = "Kalhan" });




            Console.ReadLine();
        }
    }
}
