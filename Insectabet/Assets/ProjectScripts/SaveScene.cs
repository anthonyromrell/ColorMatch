using UnityEditor;
using UnityEngine;

namespace ProjectScripts
{
	[CreateAssetMenu(fileName = "SaveScene")]
	public class SaveScene : ScriptableObject
	{

		public void SaveSceneFunc ()
		{
			AssetDatabase.SaveAssets();
			Debug.Log("Saved");
		}
	}
}
