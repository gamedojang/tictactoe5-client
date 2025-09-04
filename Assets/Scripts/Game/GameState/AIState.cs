using UnityEngine;

public class AIState : BasePlayerState
{
    public override void OnEnter(GameLogic gameLogic)
    {
        var board = gameLogic.GetBoard();
        // TODO: AI 연산
        
    }

    public override void OnExit(GameLogic gameLogic)
    {
    }

    public override void HandleMove(GameLogic gameLogic, int row, int col)
    {
    }

    protected override void HandleNextTurn(GameLogic gameLogic)
    {
    }
}
