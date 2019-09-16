using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWebApplication
{
    public class RatingType : ObjectGraphType<Rating>
    {
        public RatingType()
        {
            Field(x => x.Count);
            Field(x => x.Percent);
        }
    }
}
