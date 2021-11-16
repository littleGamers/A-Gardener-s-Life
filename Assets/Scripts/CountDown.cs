using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class CountDown : MonoBehaviour
{
    [SerializeField] int countDown;
    private Color countDownColor;

    public int GetCountDown()
    {
        return this.countDown;
    }

    public void SetCountDown(int newCountDown)
    {
        this.countDown = newCountDown;
        GetComponent<TextMeshPro>().text = countDown.ToString();
    }

    public void ChangeColorCountDown(Color newCountDownColor)
    {
        this.countDownColor = newCountDownColor;
        GetComponent<TextMeshPro>().color = newCountDownColor;
    }

    public Color getColor()
    {
        return this.countDownColor;
    }
}
