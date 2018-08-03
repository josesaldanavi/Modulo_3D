using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour {
    
    public Image image;
    public bool rege=false;

    public float speed;
    public float speedRotate;
    public GameObject playerBullet;
    public Transform gun;

    public float maxHp;
    public float life;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 35, 0)*speedRotate * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -35, 0)*speedRotate * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if(life >= 0){
                rege = false;
                life--;
                image.fillAmount = life / maxHp;
                Instantiate(playerBullet, gun.Find("canon").position, transform.rotation);
            }
        }else{
            rege = true;
        }
        if (maxHp > life && rege)
        {
            life++;
            image.fillAmount = life / maxHp;
        }
    }
}
