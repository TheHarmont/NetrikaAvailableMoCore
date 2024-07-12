using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NAMO.Domain.Entities.dbEntities;

[Table("SeparatePersons")]
public partial class SeparatePerson
{
    [Key]
    public int Id { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string? Policy { get; set; }

    [Column("MOList")]
    [Unicode(false)]
    public string? MoList { get; set; }
}
