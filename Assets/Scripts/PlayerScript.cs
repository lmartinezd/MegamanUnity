using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float velocidade;
	public float impulso;
	Rigidbody2D rb;

	SpriteRenderer spriteRender;

	public Transform chaoVerificar;
	bool estadoChao;

	// Use this for initialization
	void Start () {
		spriteRender = GetComponent<SpriteRenderer> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float move_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (move_x, 0.0f, 0.0f);

		estadoChao = Physics2D.Linecast (transform.position,
			chaoVerificar.position,1 << LayerMask.NameToLayer("Piso"));
		print (estadoChao);

		if (Input.GetButtonDown ("Jump") && (estadoChao)) {
			rb.velocity = new Vector2 (0.0f, impulso);
		}

		if (move_x > 0) {
			spriteRender.flipX = false;
		}else if(move_x < 0) {
			spriteRender.flipX = true;
		}
	}
 
}
