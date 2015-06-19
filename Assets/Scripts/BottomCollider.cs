using UnityEngine;
using System.Collections;

public class BottomCollider : MonoBehaviour {
	
	void Start () {
	
		m_LevelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		m_LevelManager.LoadLevel("Lose Screen");
	}
	
	private LevelManager m_LevelManager;
}
