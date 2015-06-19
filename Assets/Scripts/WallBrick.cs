using UnityEngine;
using System.Collections;

public class WallBrick : MonoBehaviour {

	public AudioClip m_BrickSound;
	
	void Start () {
		m_SfxVolume = PlayerPrefsManager.GetSfx();
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		AudioSource.PlayClipAtPoint(m_BrickSound, transform.position, m_SfxVolume);
	}
	
	private float m_SfxVolume;
}
