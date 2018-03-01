using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//playerの動きに対してenemyの動きを管理する（決める）クラス
public class ManagerScript : EnemyMoveScript {

	/*public static Transform playerPositionM;//今のプレイヤーの位置
	public static Transform enemyPositionM;//今の敵の位置
	Vector3 player3M = playerPositionM.eulerAngles;
	Vector3 enemy3M = enemyPositionM.eulerAngles;*/

	float kyori;//今の敵の位置とプレイヤーの位置の距離

	// Use this for initialization

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		enemyManager ();
		float kyori_x = playerPosition.transform.position.x - enemyPosition.transform.position.x;
		float kyori_z = playerPosition.transform.position.z - enemyPosition.transform.position.z;
		//距離を求める計算式
		kyori = Mathf.Sqrt((kyori_x * kyori_x) + (kyori_z * kyori_z));
		Debug.Log (kyori);

	}

	void enemyManager(){
		nomalMove ();
		if (kyori < 3) {
			dash ();
		}

		if (kyori > 3) {
			dismiss ();
		}

	}

}
