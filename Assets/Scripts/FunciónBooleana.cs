using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunciónBooleana : MonoBehaviour
{
    private bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchActive(){
        active = !active;
        gameObject.GetComponent<Animator>().SetBool("active",active);
    }

}
