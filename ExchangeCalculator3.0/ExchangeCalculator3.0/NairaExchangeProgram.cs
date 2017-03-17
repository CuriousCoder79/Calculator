using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeCalculator3._0
{
    class NairaExchangeProgram
    {
        private decimal myabokiAvgRateOne;
        private decimal myabokiAvgRateTwo;
        private decimal myTrackMasRate;
        public decimal myReciprocal;

        public decimal TrackMasRate
        {
            get { return myTrackMasRate; }
            set { myTrackMasRate = value; }
        }
        public decimal abokiAvgRateOne
        {
            get{ return myabokiAvgRateOne;  }
            set { myabokiAvgRateOne = value; }
        }
        public decimal abokiAvgRateTwo
        {
            get { return myabokiAvgRateTwo; }
            set { myabokiAvgRateTwo = value; }
        }        
        public decimal Reciprocal
        {
            get { return myReciprocal; }
            set { myReciprocal = value; }
        }
        public NairaExchangeProgram()
        {

        }

        public decimal AbokiFXAvgResult()
        {
            return Math.Round(((abokiAvgRateOne + abokiAvgRateTwo) / 2), 5);
        }

        public decimal AbokiTrackMasResult()
        {
            return Math.Round(AbokiFXAvgResult() / TrackMasRate, 5);
        }

        public decimal ResipAbokiTrackMasResult()
        {
            return Math.Round(Reciprocal / AbokiTrackMasResult(), 5);
        }
    }
}
