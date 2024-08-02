namespace ODataMetadataEndpointWithIISExpress.WebApi
{
    public class Entity1
    {
        public int Id { get; set; }
    }

    public class Entity2
    {
        public int Id { get; set; } 

        public Entity1 Entity1 { get; set; }

        public int Entity1Id { get; set; }
    }

}
