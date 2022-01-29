namespace CompanyResourceManager.DTOs
{
    public sealed class TeamDto
    {
        public TeamDto(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
