namespace contractor.Models
{
  public class Bid
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CreatorId { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
    public Account Creator { get; set; }
  }
}