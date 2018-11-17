using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Color/Generator")]
public class ColorGenerator : ScriptableObject, ICreate
{
	public List<NameID> Id;
	public List<ColorData> ObjColor;
	public GameObject RingPrefab, DotPrefab;
	public int i { get; set; }

	public void OnEnable()
	{
		i = 0;
	}

	public void Create()
	{
		Build(RingPrefab);
		Build(DotPrefab);
		
		if (i < ObjColor.Count-1)
		{
			i++;
		}
		else
		{
			i = 0;
		}
	}

	public void Build(GameObject go)
	{
		var newGo = Instantiate(go);
		newGo.GetComponent<MatchID>().ID = Id[i];
		newGo.GetComponentInChildren<SpriteRenderer>().color = ObjColor[i].Value;
	}
}

public interface ICreate
{
	int i { get; set; }
	void OnEnable();
	void Create();
	void Build(GameObject go);
}