//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string Id { get; set; }
        public string account_number { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public System.DateTime Birth { get; set; }
        public string AuthenCard { get; set; }
        public bool Isvalid { get; internal set; }
    }
}
