using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    private float minimum = 1.5f;
    private float magSpeed = 5.0f;
    private float magnification = 0.07f;

    float startOffset = 0;

    // Start is called before the first frame update
    void Start()
    {
        startOffset = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(
            this.minimum + Mathf.Sin(Time.time * this.magSpeed + startOffset) * this.magnification,
            this.transform.localScale.y,
            this.minimum + Mathf.Sin(Time.time * this.magSpeed + startOffset) * this.magnification) ;

    }
}
