namespace NhibernateTest.Domain
{
    public class PostHistory
    {
        public virtual long Id { get; set; }
        public virtual int PostHistoryTypeId { get; set; }
        public virtual long PostId { get; set; }
        public virtual string RevisionGUID { get; set; }
        public virtual string CreationDate { get; set; }
        public virtual long UserId { get; set; }
        public virtual string UserDisplayName { get; set; }
        public virtual string Comment { get; set; }
        public virtual string Text { get; set; }
       
    }
}
