using System;
using System.Collections.Generic;
using UnityEngine;

//BIG note :
// no BIIGGGEERRR
//.......................
//.......................
//......change number....
//..........to...........
//........vec1?..........
//.......................

public static class Constants
{
    public const string Number = "N";
    public const string Vec2 = "VEC2";
    public const string Vec3 = "VEC3";
}

public class Test : MonoBehaviour
{                           //0   1   2      3    4    //this will be enum or somthing
    public string semiCode = "OP ADD N/TMP N/100 N/5 ";

    Dictionary<string, Action<Vec1, Vec1, Vec1>> ValueOperations;
    Dictionary<string, Action<Vector2, Vector2, Vector2>> Vector2Operations;
    Dictionary<string, Action<Vector3, Vector3, Vector3>> Vector3Operations;
    Dictionary<string, Func<string,bool>> Condition;
    Dictionary<string, Action<List<string>>> Control;

    //we can combine this one step further Dic < type , <name , value> >
    Dictionary<string, Vec1> NumberVariables;
    Dictionary<string, Vector2> Vector2Variables;
    Dictionary<string, Vector3> Vector3Variables;

    private void Start()
    {
        ValueOperations = new Dictionary<string, Action<Vec1, Vec1, Vec1>>();
        NumberVariables = new Dictionary<string, Vec1>();

        ValueOperations.Add("ADD", ADD);
        ValueOperations.Add("SUB", SUB);
        //Control.Add("IF", IF);
        //Control.Add("FOR", FOR);
    }
    private void ADD(Vec1 left, Vec1 right, Vec1 result)
    {
        result.value = (left + right).value;
    }
    private void SUB(Vec1 left, Vec1 right, Vec1 result)
    {
        result.value = (left - right).value;
    }
    private void IF(List<string> operations)
    {
        //if a>b
    }
    private void FOR(List<string> operations)
    {

    }

    public void ProcessCode(string code)
    {
        var lines = code.Split('\n');
        foreach (var line in lines)
        {
            ProccessCodeLine(line);
        }
    }
    public void ProccessCodeLine(string codeLine)
    {
        string[] line = codeLine.Split(' ');
        // what we are gona do
        if (line[0] == "OP")
        {
            Vec1 first =  ReadNumberFromLine(line[3]);
            Vec1 second =  ReadNumberFromLine(line[4]);
            Vec1 result =  ReadNumberFromLine(line[2]);

            ValueOperations[line[1]].Invoke(first, second, result);

            Debug.Log(first.value);
            Debug.Log(second.value);
            Debug.Log(result.value);

        }
    }

    private Vec1 ReadNumberFromLine(string line)
    {
        Vec1 num = null;
        // get type and based on that get values
        string variableType = GetVariableType(line);
        string variableString = GetVariableValue(line);

        // try getting the value if its a number not a variable
        float val = 0;
        bool isVarible = !float.TryParse(variableString, out val);
        if (!isVarible)
        {
            num = new Vec1(val);
        }
        else
        {
            num = GetVariableFromDic(variableString);
        }
        return num;
    }

    private string GetVariableType(string variableTypeString)
    {
        return variableTypeString.Split('/')[0];
    }
    private string GetVariableValue(string variableString)
    {
        return variableString.Split('/')[1];
    }
    private Vec1 GetVariableFromDic(string name)
    {
        if (NumberVariables.ContainsKey(name))
        {
            return NumberVariables[name];
        }
        NumberVariables.Add(name, new Vec1(0));
        return NumberVariables[name];
    }
}
