using Microsoft.CodeAnalysis;
using SourceGen.Common;

namespace TypeWrap.SourceGen
{
    public static class SourceProductionContextExtensions
    {
        public static void OutputSource(
              this ref SourceProductionContext context
            , bool outputSourceGenFiles
            , SyntaxNode syntax
            , string source
            , string hintName
            , string sourceFilePath
            , Printer? overridePrinter = default
        )
        {
            var outputSource = TypeCreationHelpers.GenerateSourceTextForRootNodes(
                  sourceFilePath
                , syntax
                , syntax
                , source
                , context.CancellationToken
                , overridePrinter
            );

            context.AddSource(hintName, outputSource);

            if (outputSourceGenFiles)
            {
                SourceGenHelpers.OutputSourceToFile(
                      context
                    , syntax.GetLocation()
                    , sourceFilePath
                    , outputSource
                );
            }
        }
    }
}
