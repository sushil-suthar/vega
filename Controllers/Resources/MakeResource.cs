using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace vega.Controllers.Resources
{
    public class MakeResource
    {
        public MakeResource()
        {
            ModelResources = new Collection<ModelResource>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelResource> ModelResources { get; set; }
    }
    public class ModelResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
