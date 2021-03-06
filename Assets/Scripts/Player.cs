using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float _speed = 1.0f;
    [SerializeField]
    GameObject _Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
     void Update()
    {
        Movement();
        //if (Input.GetButtonDown(0))
        //{
        //    Vector3 mousePos = Input.mousePosition;
        //    {
        //        Debug.Log(mousePos.x);
        //        Debug.Log(mousePos.y);
        //    }
        //}
    }
    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.right * _speed * 1.5f * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * _speed * 1.5f * verticalInput * Time.deltaTime);



        if (transform.position.y > 4.2f)
        {
            transform.position = new Vector3(transform.position.x, 4.2f, 0);
        }
        if (transform.position.y < -3.0f)
        {
            transform.position = new Vector3(transform.position.x, -3.0f, 0);
        }



        if (transform.position.x >= 9)
        {
            transform.position = new Vector3(-9, transform.position.y, 0);
        }
        if (transform.position.x < -9f)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }

    }
}
