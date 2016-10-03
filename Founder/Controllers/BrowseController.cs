using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using Founder.Interface;
using Founder.Domain;
using Founder.Domain.Models;


namespace Founder.Controllers
{
    public class BrowseController : ApiController
    {
        private IDirectoryHelper DirectoryHelper { get; set; }
        private IFilesHelper FilesHelper {get; set;}
        private IDiskHelper DiskHelper { get; set; }


        public BrowseController(IDirectoryHelper directoryHelper, IFilesHelper filesHelper, Founder.Interface.IDiskHelper diskHelper)
        {
            DirectoryHelper = directoryHelper;
            FilesHelper = filesHelper;
            DiskHelper = diskHelper;
        }


        [HttpGet]
        public Folder GetBaseFolder()
        {
            return DirectoryHelper.GetBaseFolder();
        }


        [HttpGet]
        public Folder GetFolder([FromUri] string address = null)
        {
            return DirectoryHelper.GetFolder(address);
        }


        [HttpGet]
        public HttpResponseMessage GetFile([FromUri] string path)
        {
            return FilesHelper.DownloadFile(path);
        }

        [HttpGet]
        public Disk GetDrives()
        {
            return DiskHelper.GetDisks();
        }

    }
}
