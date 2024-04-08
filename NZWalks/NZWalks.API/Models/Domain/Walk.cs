﻿namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double LengthInKm { get; set; }

        public string? WalkImageUrl { get; set; }

        public Guid DifficultyId { get; set; }
        //defining the relationship between walk and region
        //each walk has a difficulty that is identifiable by the difficultyId
        public Guid RegionIdGuid { get; set; }


        // NAvigation properties
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }

    }
}
