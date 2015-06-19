using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		m_Paddle = GameObject.FindObjectOfType<PaddleController>();
		m_PaddleDistance = transform.position - m_Paddle.transform.position;
		
		// Set SFX Volume
		audio.volume = PlayerPrefsManager.GetSfx();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!m_bHasStarted) {
			transform.position = m_Paddle.transform.position + m_PaddleDistance;
		}
		
		if (Input.GetMouseButtonDown(0))
		{
			m_bHasStarted = true;
			rigidbody2D.velocity = new Vector2 (2f, 10f);
		}
		
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		Vector2 randomVelocity = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
		
		if(m_bHasStarted && collision.gameObject.name == "Paddle") {
			audio.Play();
			rigidbody2D.velocity += randomVelocity;
		}
	}
	
	private PaddleController m_Paddle;
	private Vector3 m_PaddleDistance;
	private bool m_bHasStarted;
}
