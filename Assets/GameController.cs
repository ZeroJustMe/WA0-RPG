using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    GameObject tmp;

    void PaintBackGround()
    {
        GameObject BackGround = Instantiate(Resources.Load("Prefebs/Map/Novice Village1") as GameObject) as GameObject;

    }

	// Use this for initialization
	void Start () {
        Destroy(GameObject.Find("Canvas"));
        tmp = GameObject.Find("Main Camera");
        PaintBackGround();
        //PaintUI();
        //PaintState();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
