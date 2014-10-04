﻿using GenericResources.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericResources.Entities
{
    public class Folder : IFolder
    {
        public string Name { get; set; }

        public IFolder ParentFolder { get; set; }
        
        public List<IFolder> ChildFolders{ get; set; }
    }
}
