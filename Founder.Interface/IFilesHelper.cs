using System;
using System.Collections.Generic;
using System.IO;
using Founder.Domain;
using System.Net;
using System.Net.Http;



namespace Founder.Interface
{
    public interface IFilesHelper
    {
        void CalculateFilesSizes(DirectoryInfo dInfo, FileSizes filesizes);
        string GetFileExtension(string fileExtension);
        HttpResponseMessage DownloadFile(string path);
    }
}
