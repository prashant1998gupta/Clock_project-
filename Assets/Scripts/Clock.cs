using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float degreesPerHour = 30f;
    const float degreesPerMinutes = 6f;
    const float degreesPerSeconds = 6f;


    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;

    public bool continuous;


    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log(hoursTransform.rotation.y);
    }

    void Start()
    {
        Debug.Log(hoursTransform.rotation.y);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hoursTransform.localScale);
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }

    void UpdateContinuous()
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            // retrive hour , minutes , second all once and use it to Quaternion.Euler;
            //DateTime time = DateTime.Now;
            //Debug.Log(DateTime.Now.Hour);
            //We can now switch between approaches, but both still do the same thing.We have to adjust UpdateContinuous so it displays fractional hours, minutes, and seconds. Unfortunately, DateTime doesn't contain convenient fractional data. Fortunately, it does have a TimeOfDay property. This gives us a TimeSpan value that contains the data in the format that we need. Specifically TotalHours, TotalMinutes, and TotalSeconds.

            hoursTransform.localRotation = Quaternion.Euler(0, (float)time.TotalHours * degreesPerHour, 0);
            minutesTransform.localRotation = Quaternion.Euler(0, (float)time.TotalMinutes * degreesPerMinutes, 0);
            secondsTransform.localRotation = Quaternion.Euler(0, (float)time.TotalSeconds * degreesPerSeconds, 0);


        }

        void UpdateDiscrete()
        {

            // retrive hour , minutes , second all once and use it to Quaternion.Euler;
            DateTime time = DateTime.Now;
            //Debug.Log(DateTime.Now.Hour);
            hoursTransform.localRotation = Quaternion.Euler(0, time.Hour * degreesPerHour, 0);
            minutesTransform.localRotation = Quaternion.Euler(0, time.Minute * degreesPerMinutes, 0);
            secondsTransform.localRotation = Quaternion.Euler(0, time.Second * degreesPerSeconds, 0);


        }
    
}