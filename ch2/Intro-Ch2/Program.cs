// Standard Includes For C# 
// Using -> Include Keyword, Can Be Prefixed With Global To Scope Entire Project
// Included By Default In GlobalUsing.g.cs File

using System;
using System.Linq;
using System.Collections.Generic;


#region C# Has Functionality For Block Grouping Via Regions -> Essentially Comment Groupings

Console.WriteLine("Hello, World!");


// C# Standard Is To Have Newline Open Braces
// As Opposed To The JS Style Of Same Line Opening Braces
if (true)
{
    Console.WriteLine("True");
}

#endregion

#region Default Includes Can Be Added To The Project File
// System.Console Was Included In The CSProj File -> Console Is A Class & Thus Requires Static Import

WriteLine("Included System.Console By Default");
#endregion

// Local Variables & Private Fields Should Be Camel Case

#region Name Of Is A Method To Find The Resolved Name Of An Rval

string name = "David";
WriteLine("The Variable: {0} Has The Value: {1}", nameof(name), name);

#endregion

// String Double Quotes
// Char Value (int) Single

string grinningFace = char.ConvertFromUtf32(0x1F600); // Unicode -> Char
WriteLine(grinningFace);

#region Types Of Strings

// Verbatim String, No Escape Characters Considered
string verbatimString = @"\t No Tab Escape Sequence";
WriteLine("Use The @ Prefix For A Verbatim String: {0}", verbatimString);

// Use Triple Quotes
string rawStringLiteral =
    """
    <fake xml/json />
    """;
WriteLine("Raw String Literal: {0}", rawStringLiteral);

// Generate JSON With $$""" To Replace Double Quotes For A JSON Element
// The Number Of $ Characters Determine The Length Of Curly Braces Needed For Interpolation
string json = $$"""
    {
        "element1": "{{"fakename"}}
    }
    """;
WriteLine("Printing JSON Element With $$ Prefix + Raw String Literal: {0}", json);

#endregion