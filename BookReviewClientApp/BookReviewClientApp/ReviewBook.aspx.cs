using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookReviewClientApp
{
    public partial class ReviewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goodreview1_Click(object sender, EventArgs e)
        {

            int Id = Convert.ToInt32(id.Text);
            string Name = name.Text;
            BookReviewClientApp.BookServiceReference.BookServiceClient proxy = new BookReviewClientApp.BookServiceReference.BookServiceClient("WSHttpBinding_IBookService");
            string per = proxy.GoodReview(Id);
            Label4.Text = "good review";
        }

        protected void avgreview_Click(object sender, EventArgs e)
        {

            int Id = Convert.ToInt32(id.Text);
            string Name = name.Text;
            BookReviewClientApp.BookServiceReference.BookServiceClient proxy = new BookReviewClientApp.BookServiceReference.BookServiceClient("WSHttpBinding_IBookService");
            string per = proxy.AverageReview(Id);
            Label4.Text = "Avg review" ;

        }

        protected void badreview_Click(object sender, EventArgs e)
        {

            int Id = Convert.ToInt32(id.Text);
            string Name = name.Text;
            BookReviewClientApp.BookServiceReference.BookServiceClient proxy = new BookReviewClientApp.BookServiceReference.BookServiceClient("WSHttpBinding_IBookService");
            string per = proxy.BadReview(Id);
            Label4.Text = "bad review";
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}