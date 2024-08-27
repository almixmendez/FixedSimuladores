using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonController : MonoBehaviour
{
    public Slider xSlider;
    public Slider ySlider;

    public float minXRotation = -45f;
    public float maxXRotation = 45f;
    public float minYRotation = -10;
    public float maxYRotation = 30;

    private void Update()
    {
        float xRotation = Mathf.Lerp(minXRotation, maxXRotation, xSlider.value);
        float yRotation = Mathf.Lerp(minYRotation, maxYRotation, ySlider.value);

        transform.rotation = Quaternion.Euler(yRotation, xRotation, 0f);
    }
}