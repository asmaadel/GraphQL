using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWebApplication
{
    public class SNTypeType : EnumerationGraphType<SNType>
    {
        public SNTypeType()
        {
            Name = "SNTypeType";
        }
    }
}
