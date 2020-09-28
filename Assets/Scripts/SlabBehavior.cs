using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SlabBehavior : MonoBehaviour
{
    private Rigidbody2D _slab;
    private float _velocityX;

    // Start is called before the first frame update
    void Start()
    {
        _slab = GetComponent<Rigidbody2D>();
        _slab.velocity = new Vector2(MathUtils.GetRandomFloat(-20,20)*Time.deltaTime,0);
    }

    // Update is called once per frame
    void Update()
    {
        //...
    }
}
