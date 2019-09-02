using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRate : MonoBehaviour {

	public int target = 30;


	void Start () {
		QualitySettings.vSyncCount = 0;

	}

	void Update () {

		if (target != Application.targetFrameRate) {
			Application.targetFrameRate = target;
		}
	}
}