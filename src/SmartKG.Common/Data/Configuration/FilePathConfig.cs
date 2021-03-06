﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartKG.Common.Data.Configuration
{
    public class FilePathConfig
    {
        public string KGFilePath { get; set; }
        public string NLUFilePath { get; set; }

        public string VCFilePath { get; set; }

        public string ContextFilePath { get; set; }
    }
}
