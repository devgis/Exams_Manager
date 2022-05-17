using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Reflection;

namespace Configer
{
   public class XmlConfig
    {
        public readonly static XmlConfig config = new XmlConfig();
        #region 字段定义
        private string _assemblyFilePath = Assembly.GetExecutingAssembly().Location;
        private string _assemblyDirPath;
        private string dbConn;
        #endregion

        public XmlConfig()
        {
            _assemblyDirPath = Path.GetDirectoryName(_assemblyFilePath);
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(_assemblyDirPath + "//AppConfig.xml");
                dbConn = xmlDocument.SelectSingleNode("/config/DbConn").InnerText;//服务名称
            }
            catch (Exception e)
            {

            }
        }
        #region 字段重构
        public string DbConn
        {
            get { return dbConn; }
            set { dbConn = value; }
        }
        #endregion
    }
}
