﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }

    public bool IsAvailable { get; set; }

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}