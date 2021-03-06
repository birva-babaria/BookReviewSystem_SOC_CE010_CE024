//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookReviewClientApp.BookServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookServiceReference.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooks", ReplyAction="http://tempuri.org/IBookService/GetBooksResponse")]
        System.Data.DataSet GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBooks", ReplyAction="http://tempuri.org/IBookService/GetBooksResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        string AddBook(string Name, string Author, string DatePublished);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        System.Threading.Tasks.Task<string> AddBookAsync(string Name, string Author, string DatePublished);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        string UpdateBook(int Id, string Name, string Author, string DatePublished);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        System.Threading.Tasks.Task<string> UpdateBookAsync(int Id, string Name, string Author, string DatePublished);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBook", ReplyAction="http://tempuri.org/IBookService/DeleteBookResponse")]
        string DeleteBook(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBook", ReplyAction="http://tempuri.org/IBookService/DeleteBookResponse")]
        System.Threading.Tasks.Task<string> DeleteBookAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GoodReview", ReplyAction="http://tempuri.org/IBookService/GoodReviewResponse")]
        string GoodReview(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GoodReview", ReplyAction="http://tempuri.org/IBookService/GoodReviewResponse")]
        System.Threading.Tasks.Task<string> GoodReviewAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AverageReview", ReplyAction="http://tempuri.org/IBookService/AverageReviewResponse")]
        string AverageReview(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AverageReview", ReplyAction="http://tempuri.org/IBookService/AverageReviewResponse")]
        System.Threading.Tasks.Task<string> AverageReviewAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/BadReview", ReplyAction="http://tempuri.org/IBookService/BadReviewResponse")]
        string BadReview(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/BadReview", ReplyAction="http://tempuri.org/IBookService/BadReviewResponse")]
        System.Threading.Tasks.Task<string> BadReviewAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : BookReviewClientApp.BookServiceReference.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<BookReviewClientApp.BookServiceReference.IBookService>, BookReviewClientApp.BookServiceReference.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public string AddBook(string Name, string Author, string DatePublished) {
            return base.Channel.AddBook(Name, Author, DatePublished);
        }
        
        public System.Threading.Tasks.Task<string> AddBookAsync(string Name, string Author, string DatePublished) {
            return base.Channel.AddBookAsync(Name, Author, DatePublished);
        }
        
        public string UpdateBook(int Id, string Name, string Author, string DatePublished) {
            return base.Channel.UpdateBook(Id, Name, Author, DatePublished);
        }
        
        public System.Threading.Tasks.Task<string> UpdateBookAsync(int Id, string Name, string Author, string DatePublished) {
            return base.Channel.UpdateBookAsync(Id, Name, Author, DatePublished);
        }
        
        public string DeleteBook(int Id) {
            return base.Channel.DeleteBook(Id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteBookAsync(int Id) {
            return base.Channel.DeleteBookAsync(Id);
        }
        
        public string GoodReview(int Id) {
            return base.Channel.GoodReview(Id);
        }
        
        public System.Threading.Tasks.Task<string> GoodReviewAsync(int Id) {
            return base.Channel.GoodReviewAsync(Id);
        }
        
        public string AverageReview(int Id) {
            return base.Channel.AverageReview(Id);
        }
        
        public System.Threading.Tasks.Task<string> AverageReviewAsync(int Id) {
            return base.Channel.AverageReviewAsync(Id);
        }
        
        public string BadReview(int Id) {
            return base.Channel.BadReview(Id);
        }
        
        public System.Threading.Tasks.Task<string> BadReviewAsync(int Id) {
            return base.Channel.BadReviewAsync(Id);
        }
    }
}
