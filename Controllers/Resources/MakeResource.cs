using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using vega.Models;

namespace vega.Controllers.Resources
{
    public class MakeResource
    {
        public MakeResource()
        {
            ModelResources = new Collection<ModelResource>();
        }
        public MakeResource(Make make)
        {
            Id = make.Id;
            Name = make.Name;
            ModelResources = new Collection<ModelResource>();
            foreach (var item in make.Models)
            {
                ModelResources.Add(new ModelResource() { Id = item.Id, Name = item.Name });
            }

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
