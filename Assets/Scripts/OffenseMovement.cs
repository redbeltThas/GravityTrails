using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffenseMovement : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        Invoke("DestroyOffense", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }

    private void DestroyOffense()
    {
        Destroy(gameObject);
    }
}
