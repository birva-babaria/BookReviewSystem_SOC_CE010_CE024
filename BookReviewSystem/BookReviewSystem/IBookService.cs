using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BookReviewSystem
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        DataSet GetBooks();
        [OperationContract]
        string AddBook(string Name, string Author, string DatePublished);
        [OperationContract]
        string UpdateBook(int Id, string Name, string Author, string DatePublished);
        [OperationContract]
        string DeleteBook(int Id);
        [OperationContract]
        string GoodReview(int Id);
        [OperationContract]
        string AverageReview(int Id);
        [OperationContract]
        string BadReview(int Id);
    }
}
