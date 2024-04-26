using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class cls_Students
    {
        private string m_Name = "";
        private string m_MSSV = "";
        private string m_Phone = "";
        private string m_DOB = "";

        #region "Properties"
        public string Name { get => m_Name; set => m_Name = value; }
        public string MSSV { get => m_MSSV; set => m_MSSV = value; }
        public string Phone { get => m_Phone; set => m_Phone = value; }
        public string DOB { get => m_DOB; set => m_DOB = value; }
        #endregion
    }
}
