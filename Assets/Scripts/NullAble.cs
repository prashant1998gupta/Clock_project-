using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullAble : MonoBehaviour
{
     double? pi;
     char? letter ;

     int m2 ;
     int? m ;

     bool? flag ;

    // An array of a nullable value type:
    int?[] arr = new int?[10];
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(flag);
        Debug.Log(pi);
        Debug.Log(letter);
        Debug.Log(m2);
        Debug.Log(m);

        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
