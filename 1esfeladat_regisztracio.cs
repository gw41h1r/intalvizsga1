// Models/SNMFYM_parametervalidacio.cs
using System.ComponentModel.DataAnnotations;

public class UserModel
{
    [Required(ErrorMessage = "Nevet megadni szükséges")]
    [MaxLength(50, ErrorMessage = "A nev nem lehet tobb 50 karakternel")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Emailt megadni kotelezo")]
    [EmailAddress(ErrorMessage = "Hamis formatum")]
    public string Email { get; set; }
}