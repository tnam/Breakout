using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	public bool m_AutoPlay;
	
	// Use this for initialization
	void Start () {
		m_Ball = GameObject.FindObjectOfType<BallController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!m_AutoPlay) {
			MouseControl();
		} 
		else {
			AIControl();
		}
	}
	
	void MouseControl() {
		
		Vector3 paddlePos = transform.position;
		
		float mousePos = Input.mousePosition.x / Screen.width * 16;
		
		paddlePos.x = Mathf.Clamp(mousePos, mk_MinMousePos, mk_MaxMousePos);
		
		transform.position = paddlePos;
	}
	
	void AIControl() {
	
		Vector3 paddlePos = transform.position;
	
		Vector3 ballPos = m_Ball.transform.position;
		
		paddlePos.x = Mathf.Clamp(ballPos.x, mk_MinMousePos, mk_MaxMousePos);
		
		transform.position = paddlePos;
	}
	
	private BallController m_Ball;
	private const float mk_MinMousePos = 0.5f;
	private const float mk_MaxMousePos = 15.5f;
}
