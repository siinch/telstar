﻿namespace Telstar.Models.Integration
{
    public class Parcel
    {
        public Guid Id { get; set; }

        public float Weight { get; set; }

        public (float depth, float height, float width) Dimensions { get; set; }

        public bool RecordedDelivery { get; set; }

        public bool Weapons { get; set; }

        public bool LiveAnimals { get; set; }

        public bool CautiousParcels { get; set; }

        public bool RefrigeratedGoods { get; set; }
    }
}