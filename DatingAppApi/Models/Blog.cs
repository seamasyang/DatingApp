using System;

namespace DatingAppApi.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedTime { get; set;}
        public int UserId { get; set; }
    }
}