﻿using System;
using System.Collections.Generic;

namespace MigAzAWS.Models
{
    public class SaveSelection
    {
        public string AWSRegion;
        public List<string> VirtualNetworks;
        public List<SaveSelectioVirtualMachine> VirtualMachines;
    }

    public class SaveSelectioVirtualMachine
    {
        public string InstanceId;
        public string InstanceName;
    }
}
