﻿using System;

public class Idea
{
    public int Id { get; set; }
    public Guid GlobalId { get; set; }
    public int IdeaListId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string User { get; set; }
    public int Status { get; set; }
    public int AccessLevel { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime EditTime { get; set; }

    public Idea() { }
}