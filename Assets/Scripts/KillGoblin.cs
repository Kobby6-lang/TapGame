using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGoblin : MonoBehaviour
{
    [SerializeField] GameObject SmokeEffect;
    [SerializeField] GameObject BottomEffect;
    public int TotalScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        TotalScore = PlayerPrefs.GetInt("Score", 0);
        TotalScore++;
        PlayerPrefs.SetInt("Score", TotalScore);
        PlayerPrefs.Save();
        Debug.Log("Score ," + TotalScore);
        Destroy(gameObject);
        Instantiate(SmokeEffect, transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bottom")
        {
            Destroy(gameObject);
        }
        Instantiate(BottomEffect, transform.position, Quaternion.identity);
    }
}
