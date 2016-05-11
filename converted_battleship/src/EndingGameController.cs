
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;

/// <summary>
/// The EndingGameController is responsible for managing the interactions at the end
/// of a game.
/// </summary>

static class EndingGameController
{

	/// <summary>
	/// Draw the end of the game screen, shows the win/lose state
	/// </summary>
	public static void DrawEndOfGame()
	{
		UtilityFunctions.DrawField(GameController.ComputerPlayer.PlayerGrid, GameController.ComputerPlayer, true);
		UtilityFunctions.DrawSmallField(GameController.HumanPlayer.PlayerGrid, GameController.HumanPlayer);

		if (GameController.HumanPlayer.IsDestroyed) {
			SwinGame.DrawTextLines("-- YOU LOSE! --", Color.White, Color.Transparent, GameResources.GameFont("ArialLarge"), FontAlignment.AlignCenter, 0, 200, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Right-click to quit game", Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 300, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Shots:" + GameController.HumanPlayer.Shots.ToString(), Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 350, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Hits:" + GameController.HumanPlayer.Hits.ToString(), Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 400, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Splashes:" + GameController.HumanPlayer.Missed.ToString(), Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 450, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Score:" + GameController.HumanPlayer.Score.ToString(), Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 500, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
		} else {
			SwinGame.DrawTextLines("-- WINNER --", Color.White, Color.Transparent, GameResources.GameFont("ArialLarge"), FontAlignment.AlignCenter, 0, 200, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Right-click to quit game", Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 300, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Shots:" + GameController.HumanPlayer.Shots.ToString(), Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 350, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Hits:" + GameController.HumanPlayer.Hits.ToString(), Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 400, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Splashes:" + GameController.HumanPlayer.Missed.ToString(), Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 450, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines("Score:" + GameController.HumanPlayer.Score.ToString(), Color.White, Color.Transparent, GameResources.GameFont("ArialMedium"), FontAlignment.AlignCenter, 0, 500, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
		}
		
	}

	/// <summary>
	/// Handle the input during the end of the game. Any interaction
	/// will result in it reading in the highsSwinGame.
	/// </summary>
	public static void HandleEndOfGameInput()
	{
		if (SwinGame.MouseClicked(MouseButton.RightButton) || SwinGame.KeyTyped(KeyCode.vk_RETURN) || SwinGame.KeyTyped(KeyCode.vk_ESCAPE)) {
			HighScoreController.ReadHighScore(GameController.HumanPlayer.Score);
			GameController.EndCurrentState();
		}
	}

}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
