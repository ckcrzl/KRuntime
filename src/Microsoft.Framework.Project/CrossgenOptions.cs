// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Framework.Project
{
    public class CrossgenOptions
    {
        public string CrossgenPath { get; set; }

        public string RuntimePath { get; set; }

        public IEnumerable<string> InputPaths { get; set; }
        
        public bool Symbols { get; set; }
    }
}
