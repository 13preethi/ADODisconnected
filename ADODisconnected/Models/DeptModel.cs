using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADODisconnected.Models
{
    public class DeptModel
    {
        public int Deptno { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }
        public string MgrName { get; set; }
    }
}