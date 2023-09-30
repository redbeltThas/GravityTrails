using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public int throwableCounter;
    public AnimateMovement avatarFacing;
    public Text collectableCounter;
    public Vector3 offset;
    //public float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        collectableCounter.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && throwableCounter > 0)
        {
            throwableCounter--;
            collectableCounter.text = throwableCounter.ToString();
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(objectThrown, throwablePosition, transform.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            Destroy(collision.gameObject);
            throwableCounter++;
            collectableCounter.text = throwableCounter.ToString();
        }
    }
}
