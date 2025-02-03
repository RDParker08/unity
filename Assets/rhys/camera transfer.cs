using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratransfer : MonoBehaviour
{
    public Vector2 cameraChange;
    public Vector2 playerChange;
    private cameratransfer cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<cameratransfer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag ("Player"))
        {
            cam.minPosition += cameratransfer;
            cam.maxPosition += cameratransfer;
            other.transform.position += playerchange;
        }
    }
}
