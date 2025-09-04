namespace LibraryManagement.Domain.src.Entities
{
    public class LoadItem
    {
        public Loan Loan { get; set; } 
        public Book Book { get; set; }
        public DateTime ItemDueDate { get; set; } 
    }
}
