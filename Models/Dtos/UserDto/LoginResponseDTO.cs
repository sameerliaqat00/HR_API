namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
