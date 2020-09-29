using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _slabCarrySpeedX;

    // Start is called before the first frame update
    void Start()
    {
        Debug.unityLogger.Log("STARTED");
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.gravityScale = 4;
    }


    // Update is called once per frame
    // This FixedUpdate is called on a fixed rate.
    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * 5 * Time.deltaTime
            + _slabCarrySpeedX * Time.deltaTime, 0, 0);
        if (_rigidbody.IsTouchingLayers(LayerMask.GetMask("Slab")) && Input.GetKeyDown(KeyCode.W))
        {
            _rigidbody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        //set speed to slab
        if (other.gameObject.tag.Equals("slab"))
        {
            _slabCarrySpeedX = other.gameObject.GetComponent<SlabBehavior>().velocityX;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("slab"))
        {
            _slabCarrySpeedX = 0;
        }
    }
}