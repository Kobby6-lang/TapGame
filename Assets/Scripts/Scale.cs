using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    GameObject goblin;
    // Start is called before the first frame update
    void Start()
    {
        goblin = GameObject.Find("GreenGoblin");
    }

    public void ScaleDown() 
    {
        goblin.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
