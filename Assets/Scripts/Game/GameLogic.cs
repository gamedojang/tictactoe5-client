
public class GameLogic
{
    public BlockController BlockController;         // Block을 처리할 객체

    private Constants.PlayerType[,] _board;         // 보드의 상태 정보

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
}
