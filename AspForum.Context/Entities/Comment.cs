using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AspForum.Context.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public int UserId{ get;set; }

        public virtual User User { get; set; }

        public int ArticleId{ get;set; }

        public virtual Article Article { get; set; }

        public DateTime PostDate { get; set; } = DateTime.Now;
    }
}