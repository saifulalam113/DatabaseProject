namespace NhibernateTest.Domain
{
    public class Badges
    {
        public virtual long Id { get; set; }
        public virtual long UserId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Date { get; set; }
        public virtual int Class { get; set; }
        public virtual string TagBased { get; set; }
    }
}
