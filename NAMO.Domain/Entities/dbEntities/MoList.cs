using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NAMO.Domain.Entities.dbEntities;

[Table("MOList")]
public partial class MoList
{
    [Key]
    public int Id { get; set; }
    public int LpuId { get; set; }
    public string? LpuFullName { get; set; }
    public bool DisplayAny { get; set; }
    public string? DistrictCode { get; set; }
    public string? CodeMO { get; set; }
    public bool OnlyAttachment { get; set; }
    public bool OnlyFemale { get; set; }
    public bool OnlyChild { get; set; }
    public bool IsActive { get; set; }
    [Column("OrdID")]
    public string? OrdId { get; set; }
}
