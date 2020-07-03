using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class ForumMessages
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public int ParentMessageId { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; }
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }
        public int LikesCount { get; set; }
        public List<int> LikerIds { get; set; }
        public int DislikeCount { get; set; }
        
        public List<int> DislikerIds { get; set; }
        
    }
}