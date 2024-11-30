// Models/felhasznalonevmodel.cs
using System.ComponentModel.DataAnnotations;

public class Felhasznalo
{
    [Required(ErrorMessage = "Ervenytelen Felhasznalo")]
    [MaxLength(50, ErrorMessage = "Nem lehet tobb bevitel mint 50 karakter")]
    public string Username { get; set; }
}
