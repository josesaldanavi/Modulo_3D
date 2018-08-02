using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra_vida : MonoBehaviour {

    Image barraVida;
    float maxVida = 10f;
    public static float vida;

	// Use this for initialization
	void Start () {

        barraVida = GetComponent<Image>();
        vida = maxVida;
	}
	
	// Update is called once per frame
	void Update () {
        barraVida.fillAmount = vida / maxVida;
	}
}
