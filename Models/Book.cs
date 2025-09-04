using Microsoft.AspNetCore.Mvc.Rendering;

namespace Thực_hành_với_view.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPages { get; set; }
        public string Summary { get; set; }

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Book 1",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b1.png",
                    Price = 9.99f,
                    TotalPages = 100,
                    Summary = "This is the summary of Book 1"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Book 2",
                    AuthorId = 2,
                    GenreId = 2,
                    Image = "/images/products/b2.png",
                    Price = 19.99f,
                    TotalPages = 200,
                    Summary = "This is the summary of Book 2"
                },
                new Book()
                {
                    Id = 3,
                    Title = "Book 3",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "/images/products/b3.png",
                    Price = 29.99f,
                    TotalPages = 300,
                    Summary = "This is the summary of Book 3"
                },
                new Book()
                {
                    Id = 4,
                    Title = "Book 4",
                    AuthorId = 4,
                    GenreId = 4,
                    Image = "/images/products/b4.png",
                    Price = 39.99f,
                    TotalPages = 400,
                    Summary = "This is the summary of Book 4"
                }
            };
            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Nam Cao", Value = "1" },
            new SelectListItem() { Text = "Ngô Tất Tố", Value = "2" },
            new SelectListItem() { Text = "Adamkhoom", Value = "3" },
            new SelectListItem() { Text = "Thiền sư Thích Nhất Hạnh", Value = "4" }
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Truyện tranh", Value = "1" },
            new SelectListItem() { Text = "Văn học đương đại", Value = "2" },
            new SelectListItem() { Text = "Phật học phổ thông", Value = "3" },
            new SelectListItem() { Text = "Truyện cười", Value = "4" }
        };
    }
}
