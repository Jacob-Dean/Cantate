using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpell : MonoBehaviour
{
    public GameObject gameObj;
    public float speed = 20f;
    //public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(transform.forward);
        //Debug.Log(GameObject.Find("Drey").GetComponent<Transform>().forward);
        //GetComponent<Rigidbody>().velocity = transform.forward * speed * Time.deltaTime;
        Destroy(gameObj,3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
