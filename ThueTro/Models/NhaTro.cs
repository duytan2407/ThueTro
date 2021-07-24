using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThueTro.Models
{
    public class NhaTro
    {
        [Key]
        [Display(Name = "STT")]
        public int IDNha { get; set; }
        [StringLength(500)]
        [Display(Name = "Tên đường")]
        public string Tenduong { get; set; }
        [Display(Name = "Diện tích")]
        public string DienTich { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên chủ nhà")]
        public string TenChuNha { get; set; }
        [Display(Name = "SDT liên hệ")]
        public string SDT { get; set; }
        [StringLength(500)]
        [Display(Name = "Chi tiết nhà")]
        public string CTNha { get; set; }
        [StringLength(500)]
        [Display(Name = "Giới thiệu")]
        public string GioiThieu { get; set; }
        [StringLength(50)]
        [Display(Name = "Giá")]
        public string Gia { get; set; }
        [Display(Name = "Ảnh")]
        public string image { get; set; }        
        //public string IDQuan { get; set; }        
        [Display(Name = "Quận")]
        [Required]
        public byte DiaDiemIdQuan { get; set; }
        public DiaDiem DiaDiem { get; set; }
        //public IEnumerable<DiaDiem> DiaDiems { get; set; }
        //public NhaTro()
        //{
        //    image = "~/Content/HinhAnh/000000000.PNG";
        //}
        //[NotMapped]
        //public HttpPostedFile ImageUpload { get; set; }
    }
}