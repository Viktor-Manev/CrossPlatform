using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatform
{
   public interface IVideoSource
    {
        string GetUri();

        string GetVideo();
    }
}
