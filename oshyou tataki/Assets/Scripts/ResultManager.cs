﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//スタートボタンを押した
	public void PushStartButton () {
		SceneManager.LoadScene ("TitleScene");	//ステージ選択シーンへ
	}
}
