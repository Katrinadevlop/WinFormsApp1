﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Group
{
    public int GroupId { get; set; }

    public string GroupName { get; set; }

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
}