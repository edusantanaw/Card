namespace Domain.Entities;


public class Card
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string List { get; private set; }

    public Card(string title, string description, string list)
    {
        Id = Guid.NewGuid(); 
        Title = title;
        Description = description;
        List = list;
    }

    public void Update(string title, string description, string list)
    {
        Title = title;
        Description = description;
        List = list;
    }
}