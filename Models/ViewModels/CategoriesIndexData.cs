namespace Laborator2_MPD.Models.ViewModels
{
    public class CategoriesIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
