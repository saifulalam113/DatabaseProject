namespace NhibernateTest.Domain
{
    public class PostLinks
    {
        public virtual long Id { get; set; }
        public virtual string CreationDate { get; set; }
        public virtual long PostId { get; set; }
        public virtual long RelatedPostId { get; set; }
        public virtual int LinkTypeId { get; set; }
    }
}
