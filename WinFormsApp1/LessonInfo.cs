﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    internal class LessonInfo
    {
        public int LessonID { get; set; }
        public string DayName { get; set; }
        public string GroupName { get; set; }
        public string TeacherName { get; set; }
        public string OfficeName { get; set; }
        public string SubjectName { get; set; }
        public Office Office { get; set; }
    }
}
