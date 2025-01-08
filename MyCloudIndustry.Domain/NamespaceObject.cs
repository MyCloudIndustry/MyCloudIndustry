using System.ComponentModel.DataAnnotations;

namespace MyCloudIndustry.Domain
{
    public class Enterprise
    {
        public string Name { get; set; }

        public IList<Site> Sites { get; set; } = [];
    }
    public class Site
    {
        public string Name { get; set; }

        public IList<Area> Areas { get; set; } = [];
    }
    public class Area
    {
        public string Name { get; set; }

        public IList<WorkCenter> WorkCenters { get; } = [];
    }
    public class WorkCenter
    {
        public string Name { get; set; }

        public IList<WorkUnit> WorkUnits { get; set; } = [];
    }
    public class WorkUnit
    {
        public string Name { get; set; }
    }




    public class NamespaceObject
    {
        [Required]
        public required string Id { get; set; }

        public required string Name { get; set; }

        public NamespaceObject? Parent { get; set; }
    }
    public class NamespaceObjectType
    {
        public static NamespaceObjectType Enterprise { get; } = new NamespaceObjectType(1, nameof(Enterprise));
        public static NamespaceObjectType Site { get; } = new NamespaceObjectType(2, nameof(Site));
        public static NamespaceObjectType Area { get; } = new NamespaceObjectType(3, nameof(Area));






        public static NamespaceObjectType ProcessCell { get; } = new NamespaceObjectType(3, nameof(ProcessCell));
        public static NamespaceObjectType ProcessLine { get; } = new NamespaceObjectType(3, nameof(ProcessLine));


        public NamespaceObjectType(int key, string name)
        {
        }
    }
}
