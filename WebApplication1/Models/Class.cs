using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//記得using這兩個命名空間--------------------------------
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//-------------------------------------------------------


namespace MvcApplication1.Models    //命名空間最好跟.designer.cs的命名空間一樣
{                                   //以免分不清楚

    [MetadataType(typeof(MemberMetaData))]
    public partial class User
    {
        private class MemberMetaData
        {
            [Required(ErrorMessage = "請輸入登入帳號")]
            [StringLength(12, ErrorMessage = "請勿超過12個字")]
            public string Id { get; set; }

            [Required(ErrorMessage = "請輸入登入密碼")]
            [StringLength(12, ErrorMessage = "請勿超過12個字")]
            public string Pwd { get; set; }


            [DisplayName("姓名")]  //顯示在欄位上的名稱
            [Required]
            public string Name { get; set; }

            [Required(ErrorMessage = "請輸入生日")]
            public DateTime Birthday { get; set; }

            [Required(ErrorMessage = "請輸入Email")]
            [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4})$", ErrorMessage = "請輸入正確的電子郵件位址.")]
            public string Email { get; set; }
        }
    }
}