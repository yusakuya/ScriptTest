using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        //順に表示する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //逆順に表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
