﻿using GenericResources.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Entities
{
    public class Concept : IResource
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
