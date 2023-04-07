using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace LAB02.Models
{
    public class Rubik 
    {
        public int Id { get; set; }
        [Display(Name = "Tên: ")]
        [Required(ErrorMessage = " Bạn phải nhập tên của Rubik")]
        public string Ten { get; set; }

        [Display(Name = "Loại: ")]
        [Required(ErrorMessage = " Bạn phải nhập loại của Rubik")]
        public string Loai { get; set; }

        [Display(Name = "Mô tả: ")]
        [Required(ErrorMessage = " Bạn phải nhập mô tả của Rubik")]
        public string MoTa { get; set; }

        [Display(Name = "Hãng: ")]
        [Required(ErrorMessage = " Bạn phải nhập hãng của Rubik")]
        public string Hang { get; set; }

        [Display(Name = "Giá: ")]
        [Required(ErrorMessage = " Bạn phải nhập giá của Rubik")]
        public int Gia { get; set; }

        [Display(Name = "Hình: ")]
        [Required(ErrorMessage = " Bạn phải dẫn hình của Rubik")]
        public string Hinh { get; set; }

        [Display(Name = "Còn lại: ")]
        [Required(ErrorMessage = " Bạn phải nhập số lượng của Rubik")]
        public int SoLgTon { get; set; }
    }
}
