namespace NhibernateTest.Domain
{
    public class Comments
    {
        public virtual long Id { get; set; }
        public virtual long PostId { get; set; }
        public virtual int Score { get; set; }
        public virtual string Text { get; set; }
        public virtual string CreationDate { get; set; }
        public virtual string UserDisplayName { get; set; }
        public virtual long UserId { get; set; }
    }
}
