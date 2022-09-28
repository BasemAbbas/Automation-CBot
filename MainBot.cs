using System;
using System.Linq;
using cAlgo.API;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;
using cAlgo.Indicators;

namespace cAlgo.Robots
{
    [Robot(TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public class FullRobot : Robot
    {
        [Parameter("Take Profit", Group = "Protection", DefaultValue = 5)]
        public int TakeProfit { get; set; }

        [Parameter("Initial Quantity (Lots)", Group = "Volume", DefaultValue = 10000)]
        public double Volume { get; set; }

        [Parameter("Constantprice", Group = "constant", DefaultValue = 55210)]
        public double Constantprice { get; set; }

        [Parameter("PipGap", Group = "Between Orders", DefaultValue = 5.5)]
        public double PipGap { get; set; }


        protected override void OnStart()
        {
            
            Positions.Closed += OnPositionsClosed;
            ExecuteMarketOrder(TradeType.Sell, "EURUSD", Volume, "First", null, TakeProfit);
            Constantprice = LastResult.Position.EntryPrice;
            for (int i = 1; i <= 200; i++)
            {
                PlaceStopOrder(TradeType.Buy, "EURUSD", Volume, Constantprice + (PipGap * i), "B"+i.ToString(), null, TakeProfit);
                PlaceStopOrder(TradeType.Sell, "EURUSD", Volume, Constantprice - (PipGap * i), "S"+i.ToString(), null, TakeProfit);
            }

        }

        private void OnPositionsClosed(PositionClosedEventArgs args)
        {
            var Position = args.Position;
            if (Position.TradeType == TradeType.Buy)
            {
                PlaceStopOrder(TradeType.Sell, "EURUSD", Volume, Position.EntryPrice, "S", null, TakeProfit);
            }
            if (Position.TradeType == TradeType.Sell)
            {
                PlaceStopOrder(TradeType.Buy, "EURUSD", Volume, Position.EntryPrice, "B", null, TakeProfit);
            }
        }

        protected override void OnTick()
        {
            if (Account.Equity >= 1200)
            {
                Notifications.SendEmail("notifications@icmarkets.com","basoma610@gmail.com","Your equity is 1002","Hi, your equity is 1002.");
            }
        }
    }
}
