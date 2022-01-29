namespace CompanyResourceManager.Models
{
    public sealed class Team
    {
        public Team(long id, string value)
        {
            Id = id;
            Value = value;
        }

        public long Id { get; }
        public string Value { get; }


    }
}
