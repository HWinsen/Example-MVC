using Agate.MVC.Base;
using ExampleGame.Module.ClickGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleGame.Gameplay
{
	public class GameplayView : BaseSceneView
	{
		[SerializeField]
		public ClickGameView ClickGameView;
	}
}
