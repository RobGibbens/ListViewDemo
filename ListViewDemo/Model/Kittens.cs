using System;
using System.Collections.Generic;

namespace ListViewDemo
{
	public static class Kittens
	{
		public static List<Kitten> GetKittens ()
		{
			return new List<Kitten> () {
				new Kitten {
					Name = "ABBEY",
					Breed = "American Wirehair",
					ImageUrl = "images/kittens/01.jpg",

				},
				new Kitten {
					Name = "BALDUR",
					Breed = "American Wirehair",
					ImageUrl = "images/kittens/02.jpg",
				},
				new Kitten {
					Name = "CLIFFORD",
					Breed = "Siamese",
					ImageUrl = "images/kittens/03.jpg",

				},
				new Kitten {
					Name = "DAISY",
					Breed = "Siamese",
					ImageUrl = "images/kittens/04.jpg",
				},
				new Kitten {
					Name = "FURBALL",
					Breed = "Persian",
					ImageUrl = "images/kittens/05.jpg",
				},
				new Kitten {
					Name = "GRUMPY CAT",
					Breed = "Persian",
					ImageUrl = "images/kittens/06.jpg",
				},
				new Kitten {
					Name = "HERCULES",
					Breed = "Persian",
					ImageUrl = "images/kittens/07.jpg",
				},
				new Kitten {
					Name = "JAKE",
					Breed = "Persian",
					ImageUrl = "images/kittens/08.jpg",
				},
				new Kitten {
					Name = "KNICKERS",
					Breed = "Oriental",
					ImageUrl = "images/kittens/09.jpg",
				},

			};          
		}
	}
}