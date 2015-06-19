using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	
	void Awake () {
		if(instance) {
			Destroy(gameObject);
		}
		else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	void Start () {
		m_AudioSource = GetComponent<AudioSource>();
	}
	
	public void SetVolume (float volume) {
		m_AudioSource.volume = volume;
	}
	
	private AudioSource m_AudioSource;
}
