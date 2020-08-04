using System;

namespace Keltek.Core.Models
{
  public class User
  {
    public Guid Id { get; set; } 

    public string Name { get; set; }

    public string Surname { get; set; }

    public int Age { get; set; }

    public string Hobby { get; set; }

    public DateTime Created { get; set; }

  }
}