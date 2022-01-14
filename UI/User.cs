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

        public User(string taikhoan, string matkhau, string email, string date, string intString,string floatString)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.email = email;
            this.date = date;
            this.intNumber=intString;
            this.floatNumber = floatString;
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
        [Date(ErrorMessage ="Ngày không đúng định dạng")]
        public string date { get; set; }

        [IsInt(ErrorMessage ="Giá trị phải là số nguyên")]
        public string intNumber { get; set; }

        [IsFloat(ErrorMessage = "Giá trị phải là số thực")]
        public string floatNumber { get; set; }
    }
}
