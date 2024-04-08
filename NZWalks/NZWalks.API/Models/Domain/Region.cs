namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }
        //for the regionImageUrl we can have null value for this property, nullable, but other properties can not have null values
        public string? RegionImageUrl { get; set; }
    }
}
