using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Founder.Domain;
using Founder.Interface;
using System.IO;
using Founder.Domain.Models;

namespace Founder.Interface
{
    public class DiskHelper : IDiskHelper
    {                     
        public Disk GetDisks()
        {
            var di = DriveInfo.GetDrives();

            Disk disk = new Disk()
            {

            };

            

            
            int i = 0;
            foreach (DriveInfo drive in di)
            {
                if (drive.IsReady && drive.DriveFormat != "HFS")
                {

                    disk.Disks.Add(new DiskItem { Id = i, Name = drive.Name.First().ToString(), Type = drive.DriveType.ToString() });
                    i++;
                }
            }


            return disk;              
        }


        
    }
}
