﻿using BookStore.Models.Models;
using BookStore.Models.Models.Users;

namespace BookStore.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Author> AuthorsData
            = new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Name = "Name 1",
                    BirthDay = DateTime.Now
                },
                new Author()
                {
                    Id = 2,
                    Name = "Name 2",
                    BirthDay = DateTime.Now
                },
                new Author()
                {
                    Id = 3,
                    Name = "Name 3",
                    BirthDay = DateTime.Now
                },
            };

        public static List<Book> BookData
            = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                  Title = "Book 1"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Book 2"
                },
                new Book()
                {
                    Id = 3,
                  Title = "Book 3"
                },
            };
    }
}
