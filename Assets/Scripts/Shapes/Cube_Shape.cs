using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Shape : Shape
{
    [Header("Cube Data")]
    [SerializeField] float rotateSpeed = 5f;
    [SerializeField] Vector3 rotateDirection = Vector3.forward;

    private void Update()
    {
        RotateBySpeed();
    }

    public void RotateBySpeed()
    {
        transform.Rotate(rotateDirection * rotateSpeed * Time.deltaTime);
    }

    protected override void DisplayText()
    {
        base.DisplayText();

        textDisplayer.text += " .att Cube";
    }
}
