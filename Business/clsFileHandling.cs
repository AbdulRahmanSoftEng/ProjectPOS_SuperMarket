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
    public class clsFileHandling
    {
        private static int _ProductID;

        private enMode _enMode;
        public clsFileHandling()
        {
            _ProductID = 0;
            _enMode = enMode.Add;
        }

        public clsFileHandling(int personID)
        {
            _ProductID = personID;
            _enMode = enMode.Update;
        }

        public string CopyImageToDirectory(string sourceImagePath)
        {
            string FileName = "";

            try{
                // التحقق من الملف المصدر
                if (!File.Exists(sourceImagePath))
                    throw new FileNotFoundException("الملف المصدر غير موجود");

                // تحديد اسم الملف الهدف
                string newFileName = Guid.NewGuid().ToString();

                if (_enMode == enMode.Add)
                {
                    FileName = newFileName + _GetExtenationFile(sourceImagePath);
                }
                else
                {

                    FileName = clsProductBackEnd.GetImageNameByProductID(_ProductID);

                    if (FileName == "")
                        FileName = newFileName + _GetExtenationFile(sourceImagePath);
                }

                string destinationPath = Path.Combine(clsShared.DefaultPathImages, FileName);

                if (!Directory.Exists(clsShared.DefaultPathImages))
                {
                    // إنشاء المجلد الهدف
                    Directory.CreateDirectory(clsShared.DefaultPathImages);
                }

                // إذا كان الملف الهدف موجوداً، حذفه أولاً
                if (File.Exists(destinationPath))
                {
                    File.SetAttributes(destinationPath, FileAttributes.Normal);
                    File.Delete(destinationPath);
                }

                if (FileName != "")
                {
                    // نسخ الملف
                    File.Copy(sourceImagePath, destinationPath);
                }
                //else
                //{
                //    // نسخ الصوره
                //    File.Copy(sourceImagePath, clsShared.DefaultPathImages);
                //}

                return FileName;
            }
            catch (Exception ex)
            {
                throw new Exception($"فشل في نسخ الصورة: {ex.Message} {FileName}", ex);
            }
        }

        private static string _GetExtenationFile(string FileName)
        {
            int IndexPoint = FileName.LastIndexOf('.');

            if (IndexPoint > 0 && IndexPoint < FileName.Length)
            {
                return FileName.Substring(IndexPoint);
            }

            return null;
        }
    }

}
