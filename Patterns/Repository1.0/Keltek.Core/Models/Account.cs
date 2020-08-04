using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Keltek.Core.Models
{
  public class Account
  {
    public int Id { get; set; }

    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }

    public string Type { get; set; }

    public decimal Amount { get; set; }

    public DateTime Created { get; set; }
  }
}