using UnityEngine;

public class ChangePieceHandler : MonoBehaviour
{
    public GameAction ChangeAction;
    // Start is called before the first frame update
    void Start()
    {
        ChangeAction.Raise += RaiseHandler ;
    }

    private void RaiseHandler (object obj)
    {
        var newPiece = obj as GamePiece;
        GetComponent<SpriteRenderer>().color = newPiece.ObjColor.Value;
        
    }
}