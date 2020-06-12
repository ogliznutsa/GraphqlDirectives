using HotChocolate.Types;

namespace GraphqlDirectives.GraphQL
{
    public class Employee
    {
        public string Name { get; set; }
        
        public string Department { get; set; }
        
        public int Age { get; set; }
    }

    public class EmployeeType : ObjectType<Employee>
    {
        protected override void Configure(IObjectTypeDescriptor<Employee> descriptor)
        {
            descriptor.Field(x => x.Age)
                .Deprecated();

            descriptor.Field(x => x.Department)
                .Directive<MyDirective>();

            base.Configure(descriptor);
        }
    }
}