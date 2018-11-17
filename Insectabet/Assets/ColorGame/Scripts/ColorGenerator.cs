using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Color/Generator")]
public class ColorGenerator : ScriptableObject, ICreate
{
	public List<NameID> Id;
	public List<ColorData> ObjColor;
	public GameObject RingPrefab, DotPrefab;
	public int I { get; set; }

	public void OnEnable()
	{
		I = 0;
	}

	public void Create()
	{
		Build(RingPrefab);
		Build(DotPrefab);
		
		if (I < ObjColor.Count-1)
		{
			I++;
		}
		else
		{
			I = 0;
		}
	}

	public void Build(GameObject go)
	{
		var newGo = Instantiate(go);
		newGo.GetComponent<MatchID>().ID = Id[I];
		newGo.GetComponentInChildren<SpriteRenderer>().color = ObjColor[I].Value;
	}
}

public interface ICreate
{
	int I { get; set; }
	void OnEnable();
	void Create();
	void Build(GameObject go);
}