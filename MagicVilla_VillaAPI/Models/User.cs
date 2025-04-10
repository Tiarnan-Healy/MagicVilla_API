namespace MagicVilla_VillaAPI.Models
{
    public class User
    {
    public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; // ** Not yet encrypted TODO
        public bool IsWebUser { get; set; } // set to true
    }
}
