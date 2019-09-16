using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWebApplication
{
    public class CommentType : ObjectGraphType<Comment>
    {
        public CommentType()
        {
            Field(x => x.Count);
            Field(x => x.Description);
            Field(x => x.Url);
        }
    }
}
