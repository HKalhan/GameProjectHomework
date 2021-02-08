using System;
using System.Collections.Generic;
using System.Text;
using GameProjectHomework.Abstract;
using GameProjectHomework.Entities;

namespace GameProjectHomework.Concrete
{
    class GameSaleManager : IGameSaleService

    {
        public void Buy(GameSale gameSale, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "   " + gamer.LastName + "   buy  " + gameSale.GameName + "   for  " + gameSale.GamePrice + "      TL.");
        }
    }
}
