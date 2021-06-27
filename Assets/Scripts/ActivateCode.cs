using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateCode : MonoBehaviour
{
    [SerializeField] private InputField codeField;
    [SerializeField] private Test codeRunner;

    public void Run()
    {
        codeRunner.ProcessCode(codeField.text.ToUpper());
    }
}
