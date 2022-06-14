using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeImage : MonoBehaviour
{
    public ChangeImage original;
    public Sprite newSprite;
    void Start()
    {

    }
    void Update() { 
    }
    public void NewImage()
    {
        original.newSprite = newSprite;

    }
}