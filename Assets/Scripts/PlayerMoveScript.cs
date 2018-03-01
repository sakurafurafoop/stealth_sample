using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : ManagerScript {
	
	void Start () {
		
	}
	
	// Update is called once per frame 常時playerの動きを送る
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			UpArrowMove ();
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			DownArrowMove ();
		} else if (Input.GetKey(KeyCode.LeftArrow)) {
			LeftArrowMove ();
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			RightArrowMove ();
		}
			
			
	}

	//上ボタンを押した時の動き
	void UpArrowMove(){
		this.gameObject.transform.position += new Vector3 (0, 0, 0.1f);
	}

	//下ボタンを押した時の動き
	void DownArrowMove(){
		this.gameObject.transform.position += new Vector3 (0, 0, -0.1f);
	}

	//左ボタンを押した時の動き
	void LeftArrowMove(){
		this.gameObject.transform.position += new Vector3 (-0.1f, 0, 0);
		this.gameObject.transform.Rotate (new Vector3 (0, -0.5f, 0));
	}

	//右ボタンを押した時の動き
	void RightArrowMove(){
		this.gameObject.transform.position += new Vector3 (0.1f, 0, 0);
		this.gameObject.transform.Rotate (new Vector3 (0, 0.5f, 0));
	}
}
