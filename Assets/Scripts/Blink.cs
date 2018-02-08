using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blink : MonoBehaviour {

	public float intervalo;
	// Use this for initialization
	IEnumerator Start () {
		GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(intervalo);
        GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(intervalo);

        StartCoroutine(Start());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("game-scene");
        }
    }

}
