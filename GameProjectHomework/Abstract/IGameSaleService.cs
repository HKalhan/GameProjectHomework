using System;
using System.Collections.Generic;
using System.Text;
using GameProjectHomework.Entities;

namespace GameProjectHomework.Abstract
{
    interface IGameSaleService
    {
        void Buy(GameSale gameSale, Gamer gamer);
    }
}
