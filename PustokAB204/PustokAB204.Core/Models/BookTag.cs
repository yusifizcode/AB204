﻿namespace PustokAB204.Core.Models;

public class BookTag : BaseEntity
{
    public int BookId { get; set; }
    public int TagId { get; set; }

    public Book Book { get; set; }
    public Tag Tag { get; set; }
}
