using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Founder.Domain.Models;

namespace Founder.Interface
{
    public interface IDirectoryHelper
     {
        IEnumerable<FileInfo> GetFilesInDirectory(string directoryPath);

        Folder GetFolder(string path);

        Folder GetBaseFolder();
    }
}
