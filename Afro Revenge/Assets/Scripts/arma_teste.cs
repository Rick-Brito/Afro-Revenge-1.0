using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma_teste : MonoBehaviour {

    public GameObject projetil;
    private Transform posPlayer;

    private void Start()
    {
        posPlayer = GetComponent<Transform>();
    }

    private void Update()
    {

        // Spawna a bala.

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projetil, posPlayer.position, posPlayer.rotation);
        }

        //

    }

}
