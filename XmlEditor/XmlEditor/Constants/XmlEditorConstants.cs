using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlEditor.Constants
{
    public class XmlEditorConstants
    {
        public static string XmlBasePath = AppDomain.CurrentDomain.BaseDirectory + @"Data\";
        public static string XmlFileName = "XmlEditorTestFile.xml";
        public static string XmlFilePath = XmlBasePath + XmlFileName;
    }
}
