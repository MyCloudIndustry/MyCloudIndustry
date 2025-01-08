using Manufactoring.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace Manufactoring.Domain.AggregatesResource.PersonnelAggregate;

public class Personnel : Entity
{
    [Required]
    public required string Id  { get; set; }

    public string? Description { get; set; }


    public IList<Person> People { get; set; }  
        = [];

    public IList<QualificationTestSpecification> QualificationTestSpecifications { get; set; } = [];
}

