using System.ComponentModel.DataAnnotations;

namespace Manufactoring.Domain.AggregatesResource.PersonnelAggregate;

public class QualificationTestSpecification
{
    [Required]
    public required string Id { get; set; }

    public required string Description { get; set; }

    public required string Version { get; set; } //TODO: Entyty
}

