using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo_melee : MonoBehaviour {

    public float velocidade;

    private Transform posPlayer;

	// Use this for initialization
	void Start () {

        posPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, velocidade*Time.deltaTime);
		
	}


    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("projetil_teste"))
        {
            Destroy(this.gameObject);
        }
    }

}
