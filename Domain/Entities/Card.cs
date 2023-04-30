namespace Domain.Entities;


public class Card
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string List { get; set; }

    public Card(string title, string description, string list, Guid? id)
    {
        Id = (Guid)(id == null ? Guid.NewGuid() : id);
        Title = title;
        Description = description;
        List = list;
    }

    public Card() { }

    public void Update(string title, string description, string list)
    {
        Title = title;
        Description = description;
        List = list;
    }
}