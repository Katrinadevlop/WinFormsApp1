﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Office
{
    public int OfficeID { get; set; }

    public int NumberSeats { get; set; }

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    public virtual ICollection<TypeOffice> OfficeTypes { get; set; } = new List<TypeOffice>();

    public static implicit operator Office(string v)
    {
        throw new NotImplementedException();
    }
}