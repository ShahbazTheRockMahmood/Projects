﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Interfaces
{
    public interface IResource
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
