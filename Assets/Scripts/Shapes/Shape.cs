using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(MeshRenderer))]
public abstract class Shape : MonoBehaviour // INHERITANCE
{
    [Header("Shape data")]
    [SerializeField] private string shapeName;
    [SerializeField] private Color shapeColor;

    private MeshRenderer shapeRenderer = null;

    public string ShapeName { get { return shapeName; } set { shapeName = value; } } // ENCAPSULATION”
    public Color ShapeColor { get { return shapeColor; } set { shapeColor = value; } } // ENCAPSULATION”


    [Header("Display Text General Data")]
    [SerializeField] protected TMP_Text textDisplayer;
    [SerializeField] protected string textToDisplay;

    protected virtual void Awake()
    {
        shapeRenderer = GetComponent<MeshRenderer>();
        shapeRenderer.material.color = shapeColor;
    }

    protected virtual void DisplayText()
    {
        textDisplayer.color = shapeColor;
        textDisplayer.text = textToDisplay;
    }

    protected void OnMouseDown()
    {
        DisplayText();
    }
}
