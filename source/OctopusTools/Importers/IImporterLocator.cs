﻿using System;
using log4net;
using Octopus.Client;
using Octopus.Platform.Util;

namespace OctopusTools.Importers
{
    public interface IImporterLocator
    {
        IImporterMetadata[] List();
        IImporter Find(string name, IOctopusRepository repository, IOctopusFileSystem fileSystem, ILog log);
    }
}