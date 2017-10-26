﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Classes
{
    public enum RoleTypes
    {
        Unknown,
        Developer,
        Releaser
    }

    public enum StateFilters{
        WellFormed,
        CreatePending,
        Deleting,
        New,
        All
    }

    public class ProjectProperties
    {
        public const string CreatedBy = "Created By";
        public const string CreatedDate = "Created Date";
        public const string CostCode= "Cost Code";

        public static string[] All = new []{ CreatedBy, CreatedDate, CostCode };
    }
}
