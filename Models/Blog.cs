using System;
using System.ComponentModel.DataAnnotations;

namespace BlogApp3.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty; // Khởi tạo với chuỗi rỗng

        [Required]
        public string Content { get; set; } = string.Empty; // Khởi tạo với chuỗi rỗng

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}