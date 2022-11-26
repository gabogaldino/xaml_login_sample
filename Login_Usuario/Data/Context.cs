using Microsoft.EntityFrameworkCore;
using System;

namespace Login_Usuario.Data;

public class Context : DbContext
{
	public Context(DbContextOptions<Context> options) : base(options)
	{
		Database.EnsureCreated();
	}

	public DbSet<Usuario> Usuarios { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Usuario>().HasData(GetUsuarios());
		base.OnModelCreating(modelBuilder);
	}

	private static Usuario[] GetUsuarios()
	{
		return new Usuario[]
		{
			new Usuario
			{
				Login = "admin@email.com",
				Senha = "admin123"
			},
		};
	}
}
