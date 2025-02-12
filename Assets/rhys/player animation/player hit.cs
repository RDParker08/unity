using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhit : MonoBehaviour
{
    [SerializeField]
    private BoxCollider2D otherCollider;
    // Start is called before the first frame update
    void Start()
    {
        //other = gameObject.GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered collision");
        Debug.Log(other);
        otherCollider = (BoxCollider2D)other;
        if (other.CompareTag("breakable"))
        {
            other.GetComponent<Pot>().Pot_break();
        }
    }




}
