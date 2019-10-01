﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(ResetBuild());
	}
	
	private IEnumerator ResetBuild()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Menu");
    }
}
