using VerdiepingS1.Class;

namespace VerdiepingS1
{
    public partial class frmBookstore : Form
    {
        private BookStore bookStore;
        public frmBookstore()
        {
            InitializeComponent();
            bookStore = new BookStore();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            string title = txbTtitle.Text;
            string authorName = txbAuthor.Text;


            Author author = new Author(authorName);
            Book book = new Book(title, author);

            bookStore.AddBook(book);
            txbTtitle.Text = "";
            txbAuthor.Text = "";
            txbPrice.Text = "";

            RefreshBookList();
        }

        private void RefreshBookList()
        {
            lbxBooks.Items.Clear();

            List<Book> books = bookStore.GetBooks();
            

            foreach (Book book in books)
            {
                string item = string.Format("{0} by {1} ", book.Title, book.Author.Name);
                lbxBooks.Items.Add(item);
            }
        }
    }
}