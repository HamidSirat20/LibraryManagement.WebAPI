namespace LibraryManagement.Domain.src.Entities;

public class Author: BaseEntity, IComparable<Author>, IEquatable<Author>
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    
    // Navigation properties
    public List<Book> Books { get; set; } = new();

    public int CompareTo(Author? other)
    {
        return string.Compare(LastName, other?.LastName, StringComparison.OrdinalIgnoreCase);
    }

    public bool Equals(Author? other)
    {
        return other != null && string.Compare(FirstName, other?.FirstName, StringComparison.OrdinalIgnoreCase) == 0 &&
               string.Compare(LastName, other?.LastName, StringComparison.OrdinalIgnoreCase) == 0 &&
               DateOfBirth == other?.DateOfBirth;
    }

    public override string ToString() => $"{FirstName} {LastName}";
}

