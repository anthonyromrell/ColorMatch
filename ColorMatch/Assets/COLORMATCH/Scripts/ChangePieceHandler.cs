using UnityEngine;

public class ChangePieceHandler : MonoBehaviour
{
    public GameAction ChangeAction;

    void Start()
    {
        ChangeAction.raise += RaiseHandler ;
    }

    private void RaiseHandler (object obj)
    {
        var newPiece = obj as GamePiece;
        GetComponentInChildren<SpriteRenderer>().color = newPiece.ObjColor.value;
        GetComponent<MatchIdBehaviour>().nameIdObj = newPiece;
    }

    private void OnDestroy()
    {
        ChangeAction.raise -= RaiseHandler ;
    }
}