namespace Hopper.Data.Models
{
    using System.Collections.Generic;

    using Hopper.Data.Common.Models;

    public class Sports : BaseModel<int>
    {
        public string Name { get; set; }

        public ICollection<PracticeCreate> Practices { get; set; }
    }
}
