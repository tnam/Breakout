using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public static int s_BrickCount;
	public Sprite[] m_HitSprites;	
	public AudioClip m_BrickSound;
	public GameObject m_Smoke;
	
	// Use this for initialization
	void Start () {
		m_SfxVolume = PlayerPrefsManager.GetSfx();
		
		++s_BrickCount;
		//print (s_BrickCount);
		m_LevelManager = GameObject.FindObjectOfType<LevelManager>();
		m_MaxHits = m_HitSprites.Length + 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		AudioSource.PlayClipAtPoint(m_BrickSound, transform.position, m_SfxVolume);
		
		++m_TimesHit;
		
		if(m_TimesHit >= m_MaxHits) {
			--s_BrickCount;
			m_LevelManager.BrickDestroyed();
			GenerateSmoke();
			Destroy (gameObject);
		}
		else {
			LoadSprites();
		}
	}
	
	void GenerateSmoke () {
		Instantiate(m_Smoke, transform.position, Quaternion.identity);
	}
	
	void LoadSprites() {
		int spriteIndex = m_TimesHit - 1;
		
		if(m_HitSprites[spriteIndex])
			GetComponent<SpriteRenderer>().sprite = m_HitSprites[spriteIndex];
		else
			Debug.LogError("Missing sprite");
	}
	
	private int m_MaxHits;
	private LevelManager m_LevelManager;
	private int m_TimesHit;
	private float m_SfxVolume;
	
}
