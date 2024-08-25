using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonController : MonoBehaviour
{
    public Slider xSlider; // Referencia al slider del eje X
    public Slider ySlider; // Referencia al slider del eje Y

    public float minXRotation = -45f; // L�mite m�nimo en X
    public float maxXRotation = 45f;  // L�mite m�ximo en X
    public float minYRotation = -10;   // L�mite m�nimo en Y
    public float maxYRotation = 30;   // L�mite m�ximo en Y

    private void Update()
    {
        // Obtener los valores de los sliders
        float xRotation = Mathf.Lerp(minXRotation, maxXRotation, xSlider.value);
        float yRotation = Mathf.Lerp(minYRotation, maxYRotation, ySlider.value);

        // Actualizar la rotaci�n del ca��n
        transform.rotation = Quaternion.Euler(yRotation, xRotation, 0f);
    }
}