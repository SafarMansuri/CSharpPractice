using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SampleWebApiwithllifeCycle.Models;

namespace SampleWebApiwithllifeCycle.Data;

public partial class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OrderItems> OrderItems { get; set; }

    public virtual DbSet<Orders> Orders { get; set; }

    public virtual DbSet<Products> Products { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderItems>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId });

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderItems_Order");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderItems_Product");
        });

        modelBuilder.Entity<Orders>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC079F2BC728");

            entity.Property(e => e.OrderedAt).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_User");
        });

        modelBuilder.Entity<Products>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC07DF20C7D4");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC074B8E38CC");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Users>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07F3179D97");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(256);

            entity.HasMany(d => d.Role).WithMany(p => p.User)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRoles",
                    r => r.HasOne<Roles>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_UserRoles_Role"),
                    l => l.HasOne<Users>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UserRoles_User"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
