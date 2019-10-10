using System;
using System.Activities;
using System.ComponentModel;

namespace CompanyABC
{
    public class FullName: CodeActivity
    {
        [Category("Input")]
        public InArgument<String> FirstName { get; set; }

        [Category("Input")]
        public InArgument<String> LastName { get; set; }

        [Category("Output")]
        public OutArgument<String> FullName1 { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var firstName = FirstName.Get(context);
            var lastName = LastName.Get(context);

            var result = firstName + " " + lastName;

            FullName1.Set(context, result);
        }

    }
}
