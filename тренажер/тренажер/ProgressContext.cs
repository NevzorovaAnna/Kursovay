using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace тренажер;

public partial class progressContext : DbContext
{

    public virtual DbSet<progress> progress { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=progress;Username=postgres; Password=ycheba2021");

}}