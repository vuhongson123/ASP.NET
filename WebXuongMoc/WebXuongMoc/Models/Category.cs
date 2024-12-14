using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebXuongMoc.Models;

public partial class Category
{
    public int Id { get; set; }
    [Display(Name ="Tiêu đề")]
    public string? Title { get; set; }

    public string? Icon { get; set; }

    public string? MateTitle { get; set; }
    [Display(Name = "Chủ đề")]
    public string? MetaKeyword { get; set; }
    [Display(Name = "Mô tả")]

    public string? MetaDescription { get; set; }

    public string? Slug { get; set; }

    public int? Orders { get; set; }
    [Display(Name = "Đơn đặt hàng")]
    public int? Parentid { get; set; }

    public DateTime? CreatedDate { get; set; }
    [Display(Name = "Ngày tạo")]
    public DateTime? UpdatedDate { get; set; }
    [Display(Name = "Ngày Cập Nhật")]
    public string? AdminCreated { get; set; }
    
    public string? AdminUpdated { get; set; }

    public string? Notes { get; set; }

    public byte? Status { get; set; }
    [Display(Name = "Trạng thái")]
    public bool? Isdelete { get; set; }
}
