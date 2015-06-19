using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string mk_MasterVolumeKey = "Master Volume";
	const string mk_SFX = "SFX";
	
	public static void SetMasterVolume(float volume) {
		if(volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat(mk_MasterVolumeKey, volume);
		} else {
			Debug.LogError("Volume out of range");
		}
	}
	
	public static float GetMasterVolume() {
		return PlayerPrefs.GetFloat(mk_MasterVolumeKey);
	}
	
	public static void SetSfx (float volume) {
		if(volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat(mk_SFX, volume);
		} else {
			Debug.LogError("Volume out of range");
		}
	}
	
	public static float GetSfx () {
		return PlayerPrefs.GetFloat(mk_SFX);
	}
}
