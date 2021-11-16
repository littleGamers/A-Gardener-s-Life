using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] string objectTag;
    [SerializeField] string textTag;
    [SerializeField] int initialTimeOut; // Get the initial timeOut for reset
    int timeOut; // Will be changed every second (decreased by 1)

    // Start is called before the first frame update
    void Start()
    {
        // Reset TimeOut to the initialTimeOut
        resetTimeOut();
        // Use Coroutine function to decrease timeOut by one every second
        StartCoroutine(decreaseTimeOut());
    }

    // Update is called once per frame
    void Update()
    {
        // If timeOut is more then 0 - set countDown to the timeOut (the timeOut changes every second)
        if (timeOut > 0)
        {
            CountDown newCountDown = GameObject.FindGameObjectWithTag(textTag).GetComponent<CountDown>();
            newCountDown.SetCountDown(timeOut);
        }
        // Else count down is over - objects (the object and its text) are disabled
        else
        {
            GameObject newObject = GameObject.FindGameObjectWithTag(objectTag);
            GameObject newTextObject = GameObject.FindGameObjectWithTag(textTag);

            if (newObject)
            {
                SpriteRenderer spawnedObject = newObject.GetComponent<SpriteRenderer>();
                spawnedObject.enabled = false;
            }

            if (newTextObject)
            {
                MeshRenderer spawnedTextObject = newTextObject.GetComponent<MeshRenderer>();
                spawnedTextObject.enabled = false;
            }
        }
    }
    // Used for real time seconds count
    private IEnumerator decreaseTimeOut()
    {
        while (true)
        {
            timeOut--;
            yield return new WaitForSecondsRealtime(1);
        }
    }

    // Function to reset timeOut 
    public void resetTimeOut()
    {
        // Update timeOut to be initialTimeOut
        timeOut = initialTimeOut;
        CountDown newCountDown = GameObject.FindGameObjectWithTag(textTag).GetComponent<CountDown>();
        // Use function in text object to change the text countDown
        newCountDown.SetCountDown(timeOut);
    }
}
