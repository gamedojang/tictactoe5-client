
public class GameLogic
{
    public BlockController BlockController;         // Block을 처리할 객체

    private Constants.PlayerType[,] _board;         // 보드의 상태 정보
    
    public BasePlayerState firstPlayerState;        // Player A
    public BasePlayerState secondPlayerState;       // Player B
    private BasePlayerState _currentPlayerState;    // 현재 턴의 Player

    public GameLogic(BlockController blockController, Constants.GameType gameType)
    {
        BlockController = blockController;
        
        // 보드의 상태 정보 초기화
        _board = 
            new Constants.PlayerType[Constants.BlockColumnCount, Constants.BlockColumnCount];
        
        // Game Type 초기화
        switch (gameType)
        {
            case Constants.GameType.SinglePlay:
                break;
            case Constants.GameType.DualPlay:
                break;
            case Constants.GameType.MultiPlay:
                break;
        }
    }

    // 턴이 바뀔 때, 기존 진행하던 상태를 Exit 하고
    // 이번 턴의 상태를 _currentPlayerState에 할당하고
    // 이번 턴의 상탱에 Enter 호출
    public void SetState(BasePlayerState state)
    {
        _currentPlayerState?.OnExit(this);
        _currentPlayerState = state;
        _currentPlayerState?.OnEnter(this);
    }
}
