namespace ChessPanel.App;

using ChessPanel.Scenes;
using System;

public class Program
{
	[STAThread]
	private static void Main()
	{
		SceneManager.Run(new MainScene());
	}
}
