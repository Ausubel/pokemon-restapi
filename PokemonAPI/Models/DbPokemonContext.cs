using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PokemonAPI.Models;

public partial class DbPokemonContext : DbContext
{
    public DbPokemonContext()
    {
    }

    public DbPokemonContext(DbContextOptions<DbPokemonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pokemon> Pokemons { get; set; }

    public virtual DbSet<PokemonDiet> PokemonDiets { get; set; }

    public virtual DbSet<PokemonRarity> PokemonRarities { get; set; }

    public virtual DbSet<PokemonSize> PokemonSizes { get; set; }

    public virtual DbSet<PokemonType> PokemonTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost; Database=db_pokemon; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pokemon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pokemon");

            entity.ToTable("pokemon");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DietId).HasColumnName("dietId");
            entity.Property(e => e.FunFact)
                .HasMaxLength(100)
                .HasColumnName("funFact");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.RarityId).HasColumnName("rarityId");
            entity.Property(e => e.SizeId).HasColumnName("sizeId");
            entity.Property(e => e.TypeId).HasColumnName("typeId");
            entity.Property(e => e.WeightKg)
                .HasMaxLength(10)
                .HasColumnName("weightKg");

            entity.HasOne(d => d.Diet).WithMany(p => p.Pokemons)
                .HasForeignKey(d => d.DietId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pokemonDiet");

            entity.HasOne(d => d.Rarity).WithMany(p => p.Pokemons)
                .HasForeignKey(d => d.RarityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pokemonRarity");

            entity.HasOne(d => d.Size).WithMany(p => p.Pokemons)
                .HasForeignKey(d => d.SizeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pokemonSize");

            entity.HasOne(d => d.Type).WithMany(p => p.Pokemons)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pokemonType");
        });

        modelBuilder.Entity<PokemonDiet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pokemonDiet");

            entity.ToTable("pokemonDiet");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
        });

        modelBuilder.Entity<PokemonRarity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pokemonRarity");

            entity.ToTable("pokemonRarity");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PokemonSize>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pokemonSize");

            entity.ToTable("pokemonSize");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
        });

        modelBuilder.Entity<PokemonType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pokemonType");

            entity.ToTable("pokemonType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
