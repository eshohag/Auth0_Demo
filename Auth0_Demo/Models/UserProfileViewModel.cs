namespace Auth0_Demo.Models
{
    public class UserProfileViewModel
    {
        public string Name { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string ProfileImage { get; set; } = null!;
        public string AccessToken { get; set; } = null!;
    }
}
