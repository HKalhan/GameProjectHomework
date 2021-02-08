using System;
using System.Collections.Generic;
using System.Text;
using GameProjectHomework.Entities;

namespace GameProjectHomework.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);

        void Delete(Campaign campaign);
    }
}
