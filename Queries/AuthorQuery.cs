﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace GraphQLWebApplication
{
    public class AuthorQuery : ObjectGraphType
    {
        public AuthorQuery(BlogService blogService)
        {
            Field<AuthorType>(
                name: "author",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return blogService.GetAuthorById(id);
                }
            );
            Field<ListGraphType<PostType>>(
                name: "posts",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return blogService.GetPostsByAuthor(id);
                }
            );
            Field<ListGraphType<SocialNetworkType>>(
                name: "socials",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return blogService.GetSNsByAuthor(id);
                }
            );
        }
    }
}
