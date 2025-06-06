﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.Models.Configurations;

public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> entity)
    {
        entity.ToTable("Customer");

        entity.HasIndex(e => e.SupportRepId, "IFK_CustomerSupportRepId");

        entity.Property(e => e.Address).HasMaxLength(70);
        entity.Property(e => e.City).HasMaxLength(40);
        entity.Property(e => e.Company).HasMaxLength(80);
        entity.Property(e => e.Country).HasMaxLength(40);
        entity.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(60);
        entity.Property(e => e.Fax).HasMaxLength(24);
        entity.Property(e => e.FirstName)
            .IsRequired()
            .HasMaxLength(40);
        entity.Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(20);
        entity.Property(e => e.Phone).HasMaxLength(24);
        entity.Property(e => e.PostalCode).HasMaxLength(10);
        entity.Property(e => e.State).HasMaxLength(40);

        entity.HasOne(d => d.SupportRep).WithMany(p => p.Customers)
            .HasForeignKey(d => d.SupportRepId)
            .HasConstraintName("FK_CustomerSupportRepId");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<Customer> modelBuilder);
}
