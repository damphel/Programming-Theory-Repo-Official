using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_Shape : Shape
{
    protected override void DisplayText()
    {
        base.DisplayText();

        textDisplayer.text += " .att Capsule";
    }
}
