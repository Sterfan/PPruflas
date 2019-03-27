using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{

    private Transform transform;
    private float shakeDuration = 0f;
    private float shakeMagnitude = 0.1f;

    Vector3 startingPosition;

    // Start is called before the first frame update
    private void Awake()
    {
        
        if(transform == null)
            transform = GetComponent(typeof(Transform)) as Transform;

    }

    private void OnEnable()
    {

        startingPosition = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(shakeDuration > 0)
        {

            transform.localPosition = startingPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeDuration -= Time.deltaTime;

        }
        else
        {

            shakeDuration = 0f;
            transform.localPosition = startingPosition;

        }
    }

    public void Shake(float magnitude, float duration)
    {

        shakeMagnitude = magnitude;
        shakeDuration = duration;

    }

}
