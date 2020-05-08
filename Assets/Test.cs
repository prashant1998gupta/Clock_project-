using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject obj;
    ColorChange onColorChange;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        //Test test = new Test();

        onColorChange += ColorApply;
        onColorChange += ColorApply2;
       // onColorChange.Invoke();
        Application.targetFrameRate = 30;
        Invoke("StopPlaying", 1);
        Debug.Log("Start Called " + Time.deltaTime);

    }

    
    void Awake()
    {
        Debug.Log("Awake Called " + Time.deltaTime);
        Debug.Log("Awake Hours Called " + (DateTime.Now));
        // Debug.Log(Time.time);
    }

    // Update is called once per frame
   /* void Update()
    {
        //time = time + Time.deltaTime;
        //Debug.Log("Update Called " + (time));
        Debug.Log("Update Called " + Time.deltaTime);
    }

    void FixedUpdate()
    {

        Debug.Log("Fixed Update Called " + Time.deltaTime);

    }*/
    void OnEnable()
    {
        Debug.Log("Onenable Called");
    }

    void Reset()
    {
        Debug.Log("Reset Called");

    }


    void StopPlaying()
    {

        this.enabled = false;
        Debug.Log(Time.time);
        Debug.Log(Time.deltaTime);

    }

    public  void ColorApply(Color color)
    {
        Debug.Log("Color has changed");
        obj.GetComponent<MeshRenderer>().material.color = color;
    }

    public void ColorApply2(Color color)
    {
        Debug.Log("Color has changed2");
        obj.GetComponent<MeshRenderer>().material.color = color;
    }

    public delegate void ColorChange(Color color);

   


    public int Sum(int a , int b)
    {
        return 0;
    }

    public int Sum(int a, int b , int c)
    {
        return 0;
    }


} 
