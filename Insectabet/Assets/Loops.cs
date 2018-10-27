using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

	public string[] Names;
	public GameObject[] Things;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < Names.Length; i++)
		{
			print(Names[i]);
		}

		foreach (var thing in Things)
		{
			print(thing);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
