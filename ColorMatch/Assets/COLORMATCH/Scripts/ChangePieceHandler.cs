using UnityEngine;

public class ChangePieceHandler : MonoBehaviour
{
    public GameAction ChangeAction;

    void Start()
    {
        ChangeAction.Raise += RaiseHandler ;
    }

    private void RaiseHandler (object obj)
    {
        var newPiece = obj as GamePiece;
        GetComponentInChildren<SpriteRenderer>().color = newPiece.ObjColor.Value;
        GetComponent<MatchID>().ID = newPiece.Id;
    }

    private void OnDestroy()
    {
        ChangeAction.Raise -= RaiseHandler ;
    }
}