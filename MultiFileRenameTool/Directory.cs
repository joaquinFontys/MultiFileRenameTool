using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFileRenameTool
{
    
    class Directory
    {
        public FileInfo[] infos;
        public DirectoryInfo[] dirs;
        public String path;
        public Boolean notClear = true;

        public Directory(FileInfo[] infos, DirectoryInfo[] dirs, String path)
        {
            this.infos = infos;
            this.dirs = dirs;
            this.path = path;
        }
        
    }
}
