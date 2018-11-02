using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorController : ScriptableObject
{
	public List<NameID> ID;
	public List<ColorData> ObjColor;
	public GameObject RingPrefab;
	public GameObject DotPrefab;
	private int i = 0;

	private void OnEnable()
	{
		i = 0;
	}


	public void Create()
	{
		var newRing = Instantiate(RingPrefab);
		newRing.GetComponent<ObjectID>().ID = ID[i];
		newRing.GetComponentInChildren<SpriteRenderer>().color = ObjColor[i].Value;
		
		var newDot = Instantiate(DotPrefab);
		newDot.GetComponent<MatchID>().ID = ID[i];
		newDot.GetComponentInChildren<SpriteRenderer>().color = ObjColor[i].Value;
		
		if (i < ObjColor.Count-1)
		{
			i++;
		}
		else
		{
			i = 0;
		}
	}
}