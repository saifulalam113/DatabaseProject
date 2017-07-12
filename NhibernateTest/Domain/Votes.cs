namespace NhibernateTest.Domain
{
    public class Votes
    {
        public virtual long Id { get; set; }
        public virtual long PostId { get; set; }
        public virtual int VoteTypeId { get; set; }
        public virtual long UserId { get; set; }
        public virtual string CreationDate { get; set; }
        public virtual int BountyAmount { get; set; }
    }
}
