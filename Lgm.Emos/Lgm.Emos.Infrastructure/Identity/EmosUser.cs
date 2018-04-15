using System;
namespace Lgm.Emos.Infrastructure.Identity
{
    public class EmosUser
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public IdentityAppUser Identity { get; set; }  // navigation property
        public string Location { get; set; }
        public string Team { get; set;  }
        public string Gender { get; set; }
    }
}
