using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumKart
{
    public interface IQueueCards
    {
        Card PeekCard
        {
            get; 
        }
        int NumberOfCards
        {
            get;
        }
        void CollectCard(Card card);
        Card PutCard();
    }
}
