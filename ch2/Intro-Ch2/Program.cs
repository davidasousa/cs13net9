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

# region Default Includes Can Be Added To The Project File
// System.Console Was Included In The CSProj File -> Console Is A Class & Thus Requires Static Import

WriteLine("Included System.Console By Default");
# endregion