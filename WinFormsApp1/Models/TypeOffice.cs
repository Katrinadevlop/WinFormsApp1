﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class TypeOffice
{
    public int OfficeTypeID { get; set; }

    public string OfficeType { get; set; }

    public virtual ICollection<Office> Offices { get; set; } = new List<Office>();
}