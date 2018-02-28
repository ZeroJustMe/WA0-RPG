using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    void PaintBackGround()
    {
        GameObject BackGround = Instantiate(Resources.Load("Prefebs/Map/Novice Village1") as GameObject) as GameObject;

    }

	// Use this for initialization
	void Start () {
        Destroy(GameObject.Find("Canvas"));
        PaintBackGround();
        //PaintUI();
        //PaintState();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
