using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
	{
		Application.LoadLevel(name);
		Brick.s_BrickCount = 0;
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
		Brick.s_BrickCount = 0;
	}
	
	public void Quit()
	{
		Application.Quit();
	}
	
	public void BrickDestroyed() {
		if(Brick.s_BrickCount <= 0) {
			LoadNextLevel();
		}
	}
}
