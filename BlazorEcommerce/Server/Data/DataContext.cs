﻿namespace BlazorEcommerce.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "The Hitchhiker's Guide to the Galaxy",
					Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film. ",
					ImageUrl = "https://cdn.kobo.com/book-images/aa60f6f0-1a2e-4527-aed3-1c35ea607532/353/569/90/False/the-ultimate-hitchhiker-s-guide-to-the-galaxy-1.jpg",
					Price = 9.99m
				},
				new Product
				{
					Id = 2,
					Title = "Ready Player One",
					Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. ",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
					Price = 7.99m
				},
				new Product
				{
					Id = 3,
					Title = "Nineteen Eighty-Four",
					Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian social science fiction novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
					ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSytkCIYezf6o1XANXYtkFT1QNMrU3vWWYLLJPLzGAiYThMDEhBdHgWmY9_YpZUtV24E8o",
					Price = 6.99m
				}
			);
		}

		public DbSet<Product> Products { get; set; }
	}
}
