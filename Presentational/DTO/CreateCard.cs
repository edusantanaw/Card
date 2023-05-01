namespace Presentational.DTO
{
    public record CreaeteCardDto
    {
        public string title { get; set; }
        public string description { get; set; }
        public string list { get; set; }

        public CreaeteCardDto(string title, string description, string list)
        {
            this.title = title;
            this.description = description;
            this.list = list;
        }

    }
}