//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZhengWeil.ExtractOil.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActionInfo
    {
        public ActionInfo()
        {
            this.R_UserInfo_ActionInfo = new HashSet<R_UserInfo_ActionInfo>();
            this.RoleInfo = new HashSet<RoleInfo>();
            this.Department = new HashSet<Department>();
        }
    
        public int ID { get; set; }
        public string SubTime { get; set; }
        public string DelFlag { get; set; }
        public string ModifiedOn { get; set; }
        public string Remark { get; set; }
        public string Url { get; set; }
        public string HttpMethod { get; set; }
        public string ActionMethod { get; set; }
        public string ControllerName { get; set; }
        public string ActionInfoName { get; set; }
        public string MenuIcon { get; set; }
        public string IconWidth { get; set; }
        public string IconHeight { get; set; }
    
        public virtual ICollection<R_UserInfo_ActionInfo> R_UserInfo_ActionInfo { get; set; }
        public virtual ICollection<RoleInfo> RoleInfo { get; set; }
        public virtual ICollection<Department> Department { get; set; }
    }
}