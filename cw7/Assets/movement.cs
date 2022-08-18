using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float inc;
    public float minpos;
    public float maxpos;
    AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minpos, maxpos), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minpos, maxpos), transform.position.y, transform.position.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "enemy")
        {
            
            Invoke("restart", 1.5f);
            playaudio();
        }
    }
    void restart()
    {
        SceneManager.LoadScene(0);
    }
    void playaudio()
    {
        src.Play();
    }
}
