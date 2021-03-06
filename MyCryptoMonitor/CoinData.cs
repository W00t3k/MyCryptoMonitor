﻿using Newtonsoft.Json;

namespace MyCryptoMonitor
{
    public class CoinData
    {
        public float cap24hrChange { get; set; }
        [JsonProperty("long")]
        public string longName { get; set; }
        public float mktcap { get; set; }
        public float perc { get; set; }
        public decimal price { get; set; }
        public bool shapeshift { get; set; }
        [JsonProperty("short")]
        public string shortName { get; set; }
        public long supply { get; set; }
        public float usdVolume { get; set; }
        public float volume { get; set; }
        public float vwapData { get; set; }
        public float vwapDataBTC { get; set; }
    }
}
