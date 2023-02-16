using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeTrigger : MonoBehaviour
{

    public int score = 0;
    public TMP_Text scoreText;

    // Start is called before the first frame update    
    void Start()
    {
        score = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        float newX = Random.Range(-12, 12);
        float newZ = Random.Range(-5, 5);
        transform.position = new Vector3(newX, 0, newZ);
        score++;
        scoreText.text = "Score: " + score;
    }
}
