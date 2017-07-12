namespace NhibernateTest.Domain
{
    public class Users
    {
        public virtual long Id { get; set; }
        public virtual int Reputation { get; set; }
        public virtual string CreationDate { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string LastAccessDate { get; set; }
        public virtual string WebsiteUrl { get; set; }
        public virtual string Location { get; set; }
        public virtual string AboutMe { get; set; }
        public virtual int Views { get; set; }
        public virtual long UpVotes { get; set; }
        public virtual long DownVotes { get; set; }
        public virtual string ProfileImageUrl { get; set; }
        public virtual string EmailHash { get; set; }
        public virtual int Age { get; set; }
        public virtual long AccountId { get; set; }
    }
}
