namespace ChessPanel.App;

using ChessPanel.App.Prefs;
using ChessPanel.Scenes;

internal class PersistentSplitContainer : SplitContainer
{
	public PersistentSplitContainer(string tag, Direction direction)
		: this(tag, direction, 0.5)
	{
	}

	public PersistentSplitContainer(string tag, Direction direction, double split) 
		: base(direction, split)
	{
		SaveManager.Save += () => SaveManager.Sync(tag, ref _split);
	}
}
