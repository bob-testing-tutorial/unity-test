using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	private float tiempo;

    // Start is called before the first frame update
    void Start()
    {
		tiempo = 1000;
    }

    // Update is called once per frame
    void Update()
    {
		tiempo += Time.deltaTime;
		
		Debug.Log("El tiempo transcurrido es: " + tiempo);
    }
}
