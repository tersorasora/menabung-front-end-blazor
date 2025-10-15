namespace BlazorAppTest.Models
{
    public class recapTransactions
    {
        public string Period { get; set; } = string.Empty;
        public double TotalIncome { get; set; } = 0.0f;
        public double TotalExpense { get; set; } = 0.0f;
        public double remainderBalance { get; set; } = 0.0f;
    }
}