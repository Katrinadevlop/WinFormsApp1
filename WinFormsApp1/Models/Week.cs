﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Week
{
    public int WeekId { get; set; }

    public int WeekNumber { get; set; }

    public int SemesterId { get; set; }

    public virtual ICollection<Day> Days { get; set; } = new List<Day>();

    public virtual Semester Semester { get; set; }
}