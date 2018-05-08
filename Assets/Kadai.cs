using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int i = 0; i < 5; i++)
            Debug.Log(array[i]);
        for (int x = 4; 0 <= x; x--)
            Debug.Log(array[x]);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
