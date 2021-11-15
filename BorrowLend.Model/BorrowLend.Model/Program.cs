using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowLend.Model
{

    public class Item
    {
        int Id;
        string Name;
        string Borrower;
        string Lender;

    }
    public class ExpenseType
    {
        int Id;
        string ExpenseTypeName;
    }
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => string.IsNullorEmpty(RequestId);
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
