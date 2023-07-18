using Inspimo_Microservice.Services.Catalog.Settings.Abstract;

namespace Inspimo_Microservice.Services.Catalog.Settings.Concrete
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CategoryCollectionName { get ; set; }
        public string ProductCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
