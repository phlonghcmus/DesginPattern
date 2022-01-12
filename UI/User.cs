using Project.ValidationFarmework.anotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Range = Project.ValidationFarmework.anotation.Range;

namespace UI
{
    internal class User
    {
        public User(string taikhoan, string matkhau, string email)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.email = email;
        }
        [Required(ErrorMessage = "Tài khoản là bắt buộc")]
        [Range(LengthMin = 8, LengthMax = 50, ErrorMessage = "Phải dài từ 8-16 ký tự")]
        public string taikhoan { get; set; }
        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        [Range(LengthMin = 8, LengthMax = 50, ErrorMessage = "Phải dài từ 8-16 ký tự")]
        
        public string matkhau { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc")]
        [Email(ErrorMessage = "Email không đúng định dạng")]
        public string email { get; set; }
    }
}
