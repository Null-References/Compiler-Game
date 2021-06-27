using System;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    public string semiCode = "";

    Dictionary<string, Action<Number, Number, Number>> ValueOperations;
    Dictionary<string, Action<Vector2, Vector2, Vector2>> Vector2Operations;
    Dictionary<string, Action<Vector3, Vector3, Vector3>> Vector3Operations;
    Dictionary<string, Action<List<string>>> Control;

    Dictionary<string, Number> NumberVariables;
    Dictionary<string, Vector2> Vector2Variables;
    Dictionary<string, Vector3> Vector3Variables;

    private void Start()
    {
        ValueOperations.Add("ADD", add);
        ValueOperations.Add("SUB", sub);
        Control.Add("IF", IF);
        Control.Add("FOR", FOR);
    }
    private void add(Number left, Number right, Number number)
    {

    }
    private void sub(Number left, Number right, Number number)
    {

    }
    private void IF(List<string> operations)
    {

    }
    private void FOR(List<string> operations)
    {

    }
    

}
