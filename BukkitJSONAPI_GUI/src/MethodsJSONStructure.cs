using System;
using System.Collections.Generic;

public class MethodsJSONListStructure
{
    public string name { get; set; }
    public string desc { get; set; }
    public string[] returns { get; set; }   // Should only contain two values, maybe reflect this by using something different from a List?
    public string call { get; set; }
    public string[][] args { get; set; }

    public Type cSharpType
    {
        get { return Type.GetType(name); }
    }
}

public class MethodsJSONFileStructure
{
    public string name { get; set; }
    public string[] depends { get; set; }
    public MethodsJSONListStructure[] methods { get; set; }
}