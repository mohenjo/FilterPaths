using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace FilterPaths
{
    internal sealed class Globals
    {
        public static readonly string AppTitle = "Filter Paths";

        public static List<DirectoryInfo> LongDirs { get; set; } = new List<DirectoryInfo>();

        public static List<FileInfo> LongFiles { get; set; } = new List<FileInfo>();

        public static List<FileInfo> BigFiles { get; set; } = new List<FileInfo>();
    }
}
