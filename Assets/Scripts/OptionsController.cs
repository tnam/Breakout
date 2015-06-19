using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	public Slider m_VolumeSlider;
	public Slider m_SfxSlider;

	public LevelManager m_LevelManager;

	// Use this for initialization
	void Start () {
	
		m_MusicPlayer = GameObject.FindObjectOfType<MusicPlayer>();
		
		m_VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		m_SfxSlider.value = PlayerPrefsManager.GetSfx();
		//print (m_VolumeSlider.value);
	}
	
	// Update is called once per frame
	void Update () {
		m_MusicPlayer.SetVolume(m_VolumeSlider.value);
	}
	
	public void SaveAndExit() {
		PlayerPrefsManager.SetMasterVolume(m_VolumeSlider.value);
		PlayerPrefsManager.SetSfx(m_SfxSlider.value);
		
		m_LevelManager.LoadLevel("Start Menu");
	}
	
	public void SetDefaults() {
		m_VolumeSlider.value = 1f;
		m_SfxSlider.value = 1f;
	}
	
	private MusicPlayer m_MusicPlayer;
}
