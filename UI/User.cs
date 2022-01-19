using Project.ValidationFarmework.anotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.CustomValidator;
using Range = Project.ValidationFarmework.anotation.Range;

namespace UI
{
    internal class User
    {
        

        public User(string taikhoan, string matkhau, string email, string date)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.email = email;
            this.date = date;
            
        }
        //[NewVal(ErrorMessage = "Không thỏa mãn New Validation")]
        [Required(ErrorMessage = "Tài khoản là bắt buộc")]
        [Range(LengthMin = 8, LengthMax = 50, ErrorMessage = "Tài khoản phải dài từ 8-16 ký tự")]
        public string taikhoan { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        [Range(LengthMin = 8, LengthMax = 50, ErrorMessage = "Mật khẩu phải dài từ 8-16 ký tự")]
        public string matkhau { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc")]
        [Email(ErrorMessage = "Email không đúng định dạng")]
        public string email { get; set; }

        [Date(ErrorMessage = "Ngày không đúng định dạng")]
        public string date { get; set; }

      

        
    }
}
