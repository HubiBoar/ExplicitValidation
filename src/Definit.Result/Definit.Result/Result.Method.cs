namespace Definit.Results;

public static partial class GenerateResult
{
    public static class Method
    {
        public static class Public
        {
            [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
            public sealed class OverrideAttribute : Attribute;

            [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
            public sealed class VirtualAttribute : Attribute;
        }

        [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
        public sealed class PublicAttribute : Attribute;
        
        public static class Private
        {
            [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
            public sealed class OverrideAttribute : Attribute;

            [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
            public sealed class VirtualAttribute : Attribute;
        }

        [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
        public sealed class PrivateAttribute : Attribute;
    }
}
