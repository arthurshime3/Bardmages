using UnityEngine;
using System.Collections;

public class SlowMo : MonoBehaviour {
	public float currentSloMo, slowTimeAllowed;

	// Use this for initialization
	void Start () {
		currentSloMo = 0f;
		slowTimeAllowed = 2.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("k_Button_A")) {
			if (Time.timeScale == 1.0f)
				Time.timeScale = 0.3f;
			else 
			{
				Time.timeScale = 1.0f;
				Time.fixedDeltaTime = 0.02f * Time.timeScale;
			}
		}

		if (Time.timeScale == 0.3f)
			currentSloMo += Time.deltaTime;

		if (currentSloMo > slowTimeAllowed) 
		{
			currentSloMo = 0f;
			Time.timeScale = 1.0f;
		}
	}
}
