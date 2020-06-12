using System;
using HotChocolate;
using Microsoft.Extensions.DependencyInjection;

namespace GraphqlDirectives.GraphQL
{
    public static class GraphQLSetup
    {
        public static IServiceCollection ConfigureGraphQL(this IServiceCollection services)
        {
            services.AddGraphQL(SchemaFactory);

            return services;
        }

        private static ISchema SchemaFactory(IServiceProvider sp) =>
            SchemaBuilder.New()
                .AddServices(sp)
                .AddQueryType<Query>()
                .AddType<EmployeeType>()
                .AddDirectiveType<MyDirective>()
                .Create();
    }
}