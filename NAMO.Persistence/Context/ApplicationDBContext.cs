using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NAMO.Domain.Entities.dbEntities;

namespace NAMO.Persistence.Context;

public partial class ApplicationDBContext : DbContext
{
    public ApplicationDBContext()
    {
    }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MoList> MoLists { get; set; }

    public virtual DbSet<SeparatePerson> SeparatePersons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Cyrillic_General_CI_AS");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
