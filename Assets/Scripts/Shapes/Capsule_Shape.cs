using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_Shape : Shape // INHERITANCE
{
    protected override void DisplayText() // POLYMORPHISM
    {
        base.DisplayText();

        textDisplayer.text += " .att Capsule";
    }
}
