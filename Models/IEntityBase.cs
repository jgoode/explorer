using System;

namespace explorer_api.Models
{
    public interface IEntityBase
    {
        int Id { get; set; }
        
        DateTime Updated { get; set; }

        DateTime Created { get; set; }
    }
}