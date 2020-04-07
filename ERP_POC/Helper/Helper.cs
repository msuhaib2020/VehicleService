using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_POC.Helper
{
    public class AjaxResponse  
    {
        public dynamic Data { get; set; }
        public int MessageType { get; set; }
        public int InsertedId { get; set; }
        public string Message { get; set; }
    }
    public enum MessageType
    {
        Success = 0,
        Error = 1,
        Warning = 2,

    }

    public static class SysMessage
    {

        public static string Create = " create successfuly..!";
        public static string Update = " update successfuly..!";
        public static string Delete = " delete successfuly..!";
        public static string RecordExsiting = " already exsiting..!";
        public static string Relation = " mapped with other detail..!";
    }
}