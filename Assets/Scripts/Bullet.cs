using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 10      ;

	// ゲームオブジェクト生成から削除するまでの時間
	public float lifeTime = 1   ;

  	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.up.normalized * speed;

		// lifeTime秒後に削除
		Destroy (gameObject, lifeTime);
	 }
	
	// Update is called once per frame
	void Update () {
	
	}
}
