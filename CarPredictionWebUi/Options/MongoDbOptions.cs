using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPredictionWebUi.Options
{
    public class MongoDbOptions
    {
        public string DatabaseUrl { get; set; }

        public string CollectionName { get; set; }

        public string DatabaseName { get; set; }
    }
}
