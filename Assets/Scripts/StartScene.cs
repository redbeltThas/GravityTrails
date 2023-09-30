using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScene : MonoBehaviour
{
   // public Animator animations;
    // Start is called before the first frame update
    void Start()
    {
        //animations.SetBool("Running", true);
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
       //animations.Play("Run");
    }
}
