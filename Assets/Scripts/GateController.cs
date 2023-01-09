using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum DefomationType
{
    Weight,
    Height
}
public class GateController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textNum;
    [SerializeField] Image topImage;
    [SerializeField] Image glassImage;
    [SerializeField] Color positiveColor;
    [SerializeField] Color negativeColor;
    [SerializeField] GameObject expandLable;
    [SerializeField] GameObject shrinkLable;
    [SerializeField] GameObject upLable;
    [SerializeField] GameObject downLable;

    public void Visual(DefomationType defomationType, int valueNum)
    {
        string prefix = "";

        if (valueNum > 0)
        {
            prefix = "+";
            OnChangeColor(positiveColor);
        }
        else if (valueNum == 0)
        {
            OnChangeColor(Color.gray);
        }
        else
        { 
            OnChangeColor(negativeColor); 
        }
        textNum.text = prefix + valueNum.ToString();

        expandLable.SetActive(false);
        shrinkLable.SetActive(false);
        upLable.SetActive(false);
        downLable.SetActive(false);
        if (defomationType == DefomationType.Height)
        {
            if (valueNum > 0)
            {
                upLable.SetActive(true);
            }
            else
                downLable.SetActive(true);
        }
        if (defomationType == DefomationType.Weight)
        {
            if (valueNum > 0)
            {
                expandLable.SetActive(true);
            }
            else
                shrinkLable.SetActive(true);
        }
    }
    void OnChangeColor(Color colorChange)
    {
        topImage.color = colorChange;
        glassImage.color = new Color(colorChange.r, colorChange.g, colorChange.b, 0.5f);
    }
}
