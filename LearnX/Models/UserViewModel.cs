using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LearnX.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
        }

        [DisplayName("ID")]
        public int uID { get; set; }

        [DisplayName("Họ và Tên")]
        [MaxLength(125, ErrorMessage = "Họ và tên không quá 125 kí tự")]
        public int uFullName { get; set; }

        [DisplayName("Giới tính")]
        public int uSex { get; set; }

        [DisplayName("Thông tin tài khoản")]
        [MaxLength(1000, ErrorMessage = "Thông tin tài khoản không quá 125 kí tự")]
        public int uInformatiion { get; set; }

        [DisplayName("Điện thoại")]
        [MaxLength(32, ErrorMessage = "Số điện thoại không quá 32 kí tự")]
        public int uMobile { get; set; }

        [DisplayName("Email")]
        [MaxLength(125, ErrorMessage = "Email không quá 125 kí tự")]
        public int uEmail { get; set; }

        public DateTime CreatedDate { get; set; }

        [DisplayName("Trạng thái")]
        public int isActive { get; set; }



    }
}
