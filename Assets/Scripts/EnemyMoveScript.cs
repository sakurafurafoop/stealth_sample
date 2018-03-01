using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveScript : MonoBehaviour {

	NavMeshAgent agent;
	public Transform playerPosition;//今のプレイヤーの位置
	public Transform enemyPosition;//今の敵の位置
	public GameObject Enemy;

	//Vector3 player3 = playerPosition.transform.position;
	//Vector3 enemy3 = enemyPosition.eulerAngles;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame 常時敵の位置をManagerに送る
	void Update () {
		agent.SetDestination(playerPosition.position);
	
	}

	//playerを見つけていない時の動き
	public void nomalMove(){
		if (enemyPosition.transform.position.z <= 20) {
			Enemy.transform.position += new Vector3 (0, 0, 0.1f);
		}
		if (enemyPosition.transform.position.x <= 20) {
			Enemy.transform.position += new Vector3 (0.1f, 0, 0);
		}
		if (enemyPosition.transform.position.x > 20) {
			Enemy.transform.position -= new Vector3 (0.1f, 0, 0);
		}
		if (enemyPosition.transform.position.z > 20) {
			Enemy.transform.position -= new Vector3 (0, 0, 0.1f);
		}
	}


	//playerを追いかけている動き
	public void dash(){
		//agent.SetDestination(playerPosition.position);
	}

	//Playerを見失い元の位置に戻る動き
	public void dismiss(){
		this.gameObject.transform.position = Vector3.MoveTowards (enemyPosition.transform.position, new Vector3 (-20, 0, -20), Time.deltaTime);
	}
			
}
