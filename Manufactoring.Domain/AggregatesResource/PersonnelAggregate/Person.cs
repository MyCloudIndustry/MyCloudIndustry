using Manufactoring.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace Manufactoring.Domain.AggregatesResource.PersonnelAggregate;

public class Person : Entity
{
    [Required]
    public required string Id { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }

    public IList<Personnel> Personnels { get; set; } = [];

    public IList<QualificationTestSpecification> QualificationTestSpecifications { get; set; } = [];
}

