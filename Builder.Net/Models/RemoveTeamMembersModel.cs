﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Net
{
    public class RemoveTeamMembersModel
    {
        public string VaultUri { get; set; }
        public string VaultClientId { get; set; }
        public string VaultClientSecret { get; set; }
        public string SourceProjectId { get; set; }
        public string GroupName { get; set; }
    }
}