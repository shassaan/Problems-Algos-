using System;
using System.Collections;
using System.Collections.Generic;

public static class StringExtensions
{
    public static void AddUniqueRange(this IEnumerable<string> stringList,Action<string,int> callback)
    {
        foreach (var stringItem in stringList)
        {
            callback(stringItem,0);
        }
    }
}