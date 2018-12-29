using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Config/Text")]
public class TextConfig : ScriptableObject, IConfig
{
    public Font FontObj;
    public int FontSize;
    public ColorData FontColor;

    public void Configure (object obj)
    {
        var newObj = obj as Text;
        if (newObj == null) return;
        newObj.font = FontObj;
        newObj.fontSize = FontSize;
    }
}

public interface IConfig
{
    void Configure (object obj);
}