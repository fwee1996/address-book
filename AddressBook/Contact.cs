//Sarah's solution:
// FirstName = "Bob", 
// LastName = "Smith",
//             Email = "bob.smith@email.com",
//             Address = "100 Some Ln, Testville, TN 11111"

public class Contact 
{
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public string? Email {get; set;}
    public string? Address {get; set;}
    public string FullName {get 
    {
        return $"{FirstName} {LastName}";
    }
    }}
//     //Devante's code: The ?? is called the Null-Coalescing Operator.
//     public string FullName2 
//     {
//         get { return $"{FirstName ?? "Unknown"} {LastName ?? "Unknown"}"; }
//     }
// }