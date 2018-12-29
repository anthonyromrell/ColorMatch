using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ColorMatch/GamePiece")]
public class GamePiece : ScriptableObject
{
    public NameID Id;
    public ColorData ObjColor;
    public Sprite ObjSprite;
}