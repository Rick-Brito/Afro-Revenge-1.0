using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public float velocidade;

    private Rigidbody2D corpo;
    private Vector2 velocidadeMovimento;
    public Animator animacao;

	// Use this for initialization
	void Start () {

        corpo = GetComponent<Rigidbody2D>();
		
	}

    // Update is called once per frame
    void Update() {

        // Movimentação

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        transform.Translate (new Vector3(h*velocidade*Time.deltaTime, v*velocidade*Time.deltaTime,0));



        //Animação
        
        //Personagem andando

        if (h != 0)
        {
            animacao.SetFloat("Velocidade", Mathf.Abs(h));    
        }
        if(v != 0)
        {
            animacao.SetFloat("Velocidade", Mathf.Abs(v));
        }
   

    }

	
}
