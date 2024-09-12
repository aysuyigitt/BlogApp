using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntitesLayer.Abstract
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; }

        void CreateTag(Tag tag);
    }
}
