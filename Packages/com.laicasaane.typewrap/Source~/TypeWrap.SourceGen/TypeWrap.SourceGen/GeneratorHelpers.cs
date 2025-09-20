using Microsoft.CodeAnalysis;
using SourceGen.Common;

namespace TypeWrap.SourceGen
{
    public static class GeneratorHelpers
    {
        public static bool IsValidCompilation(
              this Compilation compilation
            , string generatorNamespace
            , string skipAttribute
        )
        {
            return string.IsNullOrWhiteSpace(skipAttribute)
                || compilation.Assembly.HasAttribute(skipAttribute) == false;
        }
    }
}
