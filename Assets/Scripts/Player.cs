using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float _inputVertical = Input.GetAxisRaw("Vertical");
        if (_inputVertical != 0)
        {
            _rb.AddForce(new Vector2(0, _inputVertical * 3));
            Debug.Log("Moved");
        }
        */
     
        if (Input.GetAxisRaw("Mouse ScrollWheel") > 0)
        {
            _rb.velocity = new Vector2(0, _speed);


        }
        else if (Input.GetAxisRaw("Mouse ScrollWheel") < 0)
        {
            _rb.velocity = new Vector2(0, -1 * _speed);
        }
    
       
    }
}
