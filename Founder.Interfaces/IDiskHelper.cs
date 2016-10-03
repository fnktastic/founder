using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Founder.Domain;
using Founder.Domain.Models;

namespace Founder.Interface
{
    public interface IDiskHelper
    {
       Disk GetDisks();
    }
}
