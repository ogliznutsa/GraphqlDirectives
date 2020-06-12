using HotChocolate.Types;

namespace GraphqlDirectives.GraphQL
{
    public class MyDirective : DirectiveType
    {
        protected override void Configure(IDirectiveTypeDescriptor descriptor)
        {
            descriptor.Name("my");
            descriptor.Location(DirectiveLocation.FieldDefinition);
            
            base.Configure(descriptor);
        }
    }
}