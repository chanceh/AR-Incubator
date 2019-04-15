using System;
using UnityEngine;
using UnityEngine.UI;

public class RotationSlider : MonoBehaviour
{
    public Slider slider;
    public Vector3 vector;

    private void Start()
    {
        slider.onValueChanged.AddListener(delegate { ValueChangeCheck();});
    }

    private void ValueChangeCheck()
    {
        gameObject.transform.rotation = Quaternion.Euler(-slider.value, vector.y, vector.z);
    }
}
