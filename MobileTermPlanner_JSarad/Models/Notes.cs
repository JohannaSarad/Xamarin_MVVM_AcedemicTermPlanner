﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobileTermPlanner_JSarad.Models
{
    public class Notes
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Note { get; set; }
        [Indexed]
        public int CourseId { get; set; }
    }
}
