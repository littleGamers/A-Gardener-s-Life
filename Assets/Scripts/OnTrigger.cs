using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnTrigger : MonoBehaviour
{
    [SerializeField] string textTag;

    // A list of colors to choose randomly from
    List<Color> colorList = new List<Color>()
    {
        Color.blue,
        Color.yellow,
        Color.red
    };

    private void Start()
    {
        // Start with a random color chosen from the colorList
        CountDown newCountDown = GameObject.FindGameObjectWithTag(textTag).GetComponent<CountDown>();
        Color textColor = colorList[Random.Range(0, colorList.Count)];
        newCountDown.ChangeColorCountDown(textColor);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Get the right object's text and get the countDown and Timer components
        GameObject newObject = GameObject.FindGameObjectWithTag(textTag);
        CountDown newCountDown = newObject.GetComponent<CountDown>();
        Timer newTimer = GetComponent<Timer>();

        // Check if player triggered the WaterBacket and it is the right color
        if ("WaterBacket" == other.tag && newCountDown.getColor() == Color.blue)
        {
            // Reset time to the initialTimeOut
            newTimer.resetTimeOut();
            // Change randomly the color from the colorList when triggered
            Color textColor = colorList[Random.Range(0, colorList.Count)];
            newCountDown.ChangeColorCountDown(textColor);

        }
        // Check if player triggered the ChemicalBottle and it is the right color
        else if ("ChemicalBottle" == other.tag && newCountDown.getColor() == Color.yellow)
        {
            // Reset time to the initialTimeOut
            newTimer.resetTimeOut();
            // Change randomly the color from the colorList when triggered
            Color textColor = colorList[Random.Range(0, colorList.Count)];
            newCountDown.ChangeColorCountDown(textColor);
        }
        // Check if player triggered the Fertilizer and it is the right color
        else if ("Fertilizer" == other.tag && newCountDown.getColor() == Color.red)
        {
            // Reset time to the initialTimeOut
            newTimer.resetTimeOut();
            // Change randomly the color from the colorList when triggered
            Color textColor = colorList[Random.Range(0, colorList.Count)];
            newCountDown.ChangeColorCountDown(textColor);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
