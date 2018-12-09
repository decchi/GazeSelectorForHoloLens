using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {



    public void ColorChangeBlue(Renderer renderer)
    {
        renderer.material.color = Color.blue;
    }

    public void ColorChangeGreen(Renderer renderer)
    {
        renderer.material.color = Color.green;
    }

}
