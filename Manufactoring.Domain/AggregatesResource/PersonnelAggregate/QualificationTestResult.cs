using System.ComponentModel.DataAnnotations;

namespace Manufactoring.Domain.AggregatesResource.PersonnelAggregate;

public class QualificationTestResult
{
    [Required]
    public required string Id { get; set; }

    public string? Description { get; set; }

    public required string Result { get; set; } //TODO: Entyty

    public required DateTime DateTime { get; set; }

    public DateTime? Validity { get; set; }
}

