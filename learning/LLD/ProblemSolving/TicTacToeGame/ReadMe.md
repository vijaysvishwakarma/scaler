TicTacToe Game Requirement
 - Size of the board N X N
 - No of players => (n-1) . each player has their own symbolx, min 2 playes (assuming Bot is a player)
- Every player can choose, their own symboxs, as any char at start of the game, no two player can have same charactor.
- At begining , we will randomzie the palyer list and move in that order.
- Player list => A B C D randomize C B A D
- If any player achives same marking across a row , column or diagonal. player wins.
- Draw if matrix | board is fill and no wining player
- Will the game have bots => if yes,
only 1 bot per game allowed
- Will bots have difficulty level => yes, EASY, MEDIUM and HARD
- Timer between moves => No
- Game ends when somebody won or game is draw.
- Tournament => X
- Pause | resume | exit | fofeit => No
- Leaderboard => No
- Allow players to undo their moves
- Blocked cells
- Rewatch of the game should be available

Any Game Requirement:

- Size | design of board
- No of players
- Bots , with difficulty levels
- Leaderboard 
- Undo
- How many undos are possible
- How game starts
- How game ends
- Rewatch after a game ends
- How   will each players turn will come up
- Wining , draw or loose conditions


Activity needs to perform
- Draw Use Case Diagram
- Draw Class Diagram
- Write Code, atleast should be running. 
- Follow sold principles
- Design patterns


Classes in Game

Board
     Dimension
     List<Cell> cells

Cell
    Row row
    Col col
    CellState cellState             CellState=> EMPTY, FULL, BLOCKED
    Player player


Player                          PlayerType
    Id                           EASY_BOT, MEDIUM_BOT, HARD_BOT,HUMAN
    Name
    Symbol
    PlayerType
PlayGame
    Move
Game
    List<Player> players
    Board board
    List<Move> moves
    int nextPlayerIndex
    GameState                      GameState =>END, DRAW, INPROGRESS


Move
 Player player
 Cell cell



