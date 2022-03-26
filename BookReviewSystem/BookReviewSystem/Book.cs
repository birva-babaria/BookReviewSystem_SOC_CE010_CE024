using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookReviewSystem
{
    [DataContract]
    public class Book
    {
        private int Id;
        private string Name;
        private string Author;
        private string DatePublished;
        private int Good;
        private int Average;
        private int Bad;

        [DataMember]
        public int bId
        {
          get { return Id; }
          set { Id = value; }
        }

        [DataMember]
        public string bName
        {
            get { return Name; }
            set { Name = value; }
        }

        [DataMember]
        public string bAuthor
        {
            get { return Author; }
            set { Author = value; }
        }

        [DataMember]
        public string bDatePublished
        {
            get { return DatePublished; }
            set { DatePublished = value; }
        }

        [DataMember]
        public int bGood
        {
            get { return Good; }
            set { Good = value; }
        }
        [DataMember]

        public int bAverage
        {
            get { return Average; }
            set { Average = value; }
        }
        [DataMember]

        public int bBad
        {
            get { return Bad; }
            set { Bad = value; }
        }
    }
}
