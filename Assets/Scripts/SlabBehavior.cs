using System;
using UnityEngine;

public class SlabBehavior : MonoBehaviour
{
    private GameObject _slab;
    private float _velocityX;

    
    
    // Start is called before the first frame update
    void Start()
    {
        _slab = gameObject;
        _velocityX = MathUtils.GetRandomFloat(-3, 3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _slab.transform.Translate(_velocityX*Time.deltaTime,0,0);

    }

    private void OnDestroy()
    {
        Destroy(_slab);
    }

    private void OnBecameInvisible()
    {
        OnDestroy();
    }
}
