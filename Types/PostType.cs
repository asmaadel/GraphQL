﻿using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWebApplication
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.Url);
            Field(x => x.Date);
            Field(x => x.Description);
            Field<AuthorType>("author");
            Field<RatingType>("rating");
            Field<ListGraphType<CommentType>>("comments");
            Field(x => x.Categories, nullable: true);
        }
    }
}
