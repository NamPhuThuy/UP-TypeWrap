using UnityEngine;

namespace TypeWrap.Samples
{
    [WrapType(typeof(int), ExcludeConverter = true)]
    public partial struct HeroId { }

    [WrapType(typeof(int), "wrappedValue")]
    public partial struct IntWrapper { }

    [WrapRecord]
    public readonly partial record struct Coord2D(Vector2Int _);
}