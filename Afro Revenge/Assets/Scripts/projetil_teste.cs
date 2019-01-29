using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil_teste : MonoBehaviour {

    private Vector2 alvo;
    public float velocidade;

    private void Start()
    {
        alvo = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Update()
    {
        // Movimento e destruição do projétil.

        transform.position = Vector2.MoveTowards(transform.position, alvo, velocidade * Time.deltaTime);

        if (Vector2.Distance(transform.position,alvo) < 0.2f)
        {
            Destroy(this.gameObject);
        }
   
        //
    }

}
