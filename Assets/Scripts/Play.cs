using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    public void StartAnim() 
    {
        Anim.SetTrigger("Active");
    }

    public void PlayGameScene() 
    {
        SceneManager.LoadScene("TapGame");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
