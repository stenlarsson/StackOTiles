using StackOTiles.GamePlay;

namespace StackOTiles.Screens
{
    class InputQueueItem
    {
        public readonly int Time;
        public readonly PlayerInput Input;

        public InputQueueItem(int time, PlayerInput input)
        {
            Time = time;
            Input = input;
        }
    }
}
