﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentations.Logic.Repositories
{
    public class PresentationAdd_DTO
    {
        public string Title { get; set; }

        public bool IsAccessible { get; set; }

        public string TeacherId { get; set; }
        public string CourseId { get; set; }
    }
}
