using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{

    private Animator anim;
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pot_break()
    {
        anim.SetBool("Pot_break", true);
        StartCoroutine(destroy_action());
        
    }
    IEnumerator destroy_action()
    {
        yield return new WaitForSeconds(.3f);
        Destroy(this.gameObject);
    }


}
