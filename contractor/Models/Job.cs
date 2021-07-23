using System;

namespace contractor.Models
{
  public class Job
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string CreatorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}