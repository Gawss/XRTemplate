using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using VRKeys;

public class InputFieldBehavior : MonoBehaviour
{
    [HideInInspector] public TMP_InputField inputFieldPro;
    public KeyboardBehavior keyboard;

    // Start is called before the first frame update
    void Start()
    {
        inputFieldPro = this.GetComponent<TMP_InputField>();
    }

    public void SetKeyboardInput()
    {
        keyboard.targetInput = inputFieldPro;
    }
}
