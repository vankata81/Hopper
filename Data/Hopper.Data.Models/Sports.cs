namespace Hopper.Data.Models
{
    using System.Collections.Generic;

    using Hopper.Data.Common.Models;

    public class Sports : BaseModel<int>
    {
        public Sports()
        {
            this.Practices = new HashSet<PracticeCreate>();
        }

        public string Name { get; set; }

        public virtual ICollection<PracticeCreate> Practices { get; set; }
    }
}
