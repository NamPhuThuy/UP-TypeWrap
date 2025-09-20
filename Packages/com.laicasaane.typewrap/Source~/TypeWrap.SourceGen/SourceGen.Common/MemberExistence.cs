namespace SourceGen.Common
{
    public readonly record struct MemberExistence(bool DoesExist, bool IsStatic, bool IsNullable);
}
