using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCActionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact()
    {
        Debug.Log("Talked to " + this.name);
    }
}
