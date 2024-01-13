// Code authored by Dean Edis (DeanTheCoder).
// Anyone is free to copy, modify, use, compile, or distribute this software,
// either in source code form or as a compiled binary, for any non-commercial
// purpose.
//
// If you modify the code, please retain this copyright header,
// and consider contributing back to the repository or letting us know
// about your modifications. Your contributions are valued!
//
// THE SOFTWARE IS PROVIDED AS IS, WITHOUT WARRANTY OF ANY KIND.

using System.Collections;
using System.Text;

namespace CSharp.Utils.Extensions;

public static class EnumerableExtensions
{
    public static string ToCsv(this IList collection)
    {
        var sb = new StringBuilder();
        foreach (var o in collection)
        {
            if (sb.Length > 0)
                sb.Append(',');
            sb.Append(o);
        }

        return sb.ToString();
    }
}