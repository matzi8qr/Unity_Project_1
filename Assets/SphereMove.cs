using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    public GameObject pauseObject;
    private bool countdown = false;;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        countdown = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        float speed = 10 * Time.deltaTime;
        float horizMove = Input.GetAxisRaw("Horizontal") * speed;
        float vertMove = Input.GetAxisRaw("Vertical") * speed;
        transform.position += new Vector3(horizMove, 0, vertMove);

        // Pause
        if (Input.GetKeyDown(KeyCode.Space)){
            if (Time.timeScale == 0){
                Time.timeScale = 1;
                pauseObject.SetActive(false);
            } else {
                Time.timeScale = 0;
                pauseObject.SetActive(true);
            }
        }

        // Quit
        if (Input.GetKeyDown(KeyCode.Q)){
            condtown = true;
        }
        if (countdown) {
            if (timer < 3){
                timer += Time.deltaTime;
            } else {
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
    }
}
