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
		Build(RingPrefab, "ObjectID");
		Build(DotPrefab, "MatchID");
		
		if (i < ObjColor.Count-1)
		{
			i++;
		}
		else
		{
			i = 0;
		}
	}

	public void Build(GameObject go, string obj)
	{
		var newGo = Instantiate(go);
		
		if (obj == "ObjectID")
		{
			newGo.GetComponent<ObjectID>().ID = ID[i];
		}
		else
		{
			newGo.GetComponent<MatchID>().ID = ID[i];
		}
		newGo.GetComponentInChildren<SpriteRenderer>().color = ObjColor[i].Value;
	}
}