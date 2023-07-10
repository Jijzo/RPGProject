using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public SelectHairColor selectHairColor;

    [Header("Color Values")]
    [SerializeField] float redAmount;
    [SerializeField] float greenAmount;
    [SerializeField] float blueAmount;

    [Header("Color Sliders")]
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    public Image colorImage;

    private void Awake()
    {
        colorImage = GetComponent<Image>();
        redAmount = colorImage.color.r;
        greenAmount = colorImage.color.g;
        blueAmount = colorImage.color.b;
    }

    public void SetSliderValuesToImageColor()
    {
        redSlider.value = redAmount;
        greenSlider.value = greenAmount;
        blueSlider.value = blueAmount;

        selectHairColor.redAmount = redAmount;
        selectHairColor.greenAmount = greenAmount;
        selectHairColor.blueAmount = blueAmount;
        selectHairColor.SetHairColor();
    }
}
