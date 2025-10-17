namespace BlazorAppTest.Models
{
    public class recapTransactions
    {
        public string Period { get; set; } = string.Empty;
        public decimal TotalIncome { get; set; } = 0;
        public decimal TotalExpense { get; set; } = 0;
        public decimal remainderBalance { get; set; } = 0;
    }
}