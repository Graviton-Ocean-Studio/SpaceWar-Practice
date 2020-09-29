using System;
using UnityEngine;

public class SlabBehavior : MonoBehaviour
{
    private GameObject _slab; 
    public float velocityX;

    
    
    // Start is called before the first frame update
    void Start()
    {
        _slab = gameObject;
        velocityX = MathUtils.GetRandomFloat(-3, 3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _slab.transform.Translate(velocityX*Time.deltaTime,0,0);
    }

    private void OnDestroy()
    {
        //TODO: add explosion animation
        Destroy(_slab);
    }

    private void OnBecameInvisible()
    {
        OnDestroy();
    }
}
