using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movehero : MonoBehaviour
{ 
    public GameObject snowballClonTemplate;

    Animator animator;
    Collider Collider;
    // Start is called before the first frame update
    void Start()
    {
      animator = GetComponent<Animator>(); 
    }
       
    // Update is called once per frame
    void  Update()

    {
        animator.SetBool("isRunning", false);
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newSnowballGO = Instantiate(snowballClonTemplate, transform.position + transform.forward + Vector3.up, Quaternion.identity);
            snowballl myNewSnowball = newSnowballGO.GetComponent<snowballl>();
            myNewSnowball.throwSnowball(transform);
        }


        if (Input.GetKey(KeyCode.W))
        { transform.position += transform.forward * Time.deltaTime;
         animator.SetBool("isRunning", true); }

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, 30* Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, -30 * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.position += Vector3.forward;
        Footballscript myFootball = collision.gameObject.GetComponent<Footballscript>();
        if (myFootball != null)
        {
            myFootball.kick();
        }

    }




}
    