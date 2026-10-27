using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using BackEnd;

namespace Business
{
    public class clsShared
    {
        public static string DefaultPathImages = @"c:\POS_PATH_IMAGES";
    }
    
    public enum enMode
    {
        Add,
        Update
    };

}
