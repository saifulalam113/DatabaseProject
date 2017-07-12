namespace NhibernateTest.Domain
{
    public class Posts
    {
        public virtual long Id { get; set; }
        public virtual int PostTypeId { get; set; }
        public virtual long AcceptedAnswerId { get; set; }
        public virtual long ParentId { get; set; }
        public virtual string CreationDate { get; set; }
        public virtual string DeletionDate { get; set; }
        public virtual int Score { get; set; }
        public virtual int ViewCount { get; set; }
        public virtual string Body { get; set; }
        public virtual long OwnerUserId { get; set; }
        public virtual string OwnerDisplayName { get; set; }
        public virtual long LastEditorUserId { get; set; }
        public virtual string LastEditorDisplayName { get; set; }
        public virtual string LastEditDate { get; set; }
        public virtual string LastActivityDate { get; set; }
        public virtual string Title { get; set; }
        public virtual string Tags { get; set; }
        public virtual int AnswerCount { get; set; }
        public virtual int CommentCount { get; set; }
        public virtual int FavoriteCount { get; set; }
        public virtual string ClosedDate { get; set; }
        public virtual string CommunityOwnedDate { get; set; }
    }
}
