using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{

    public BallPrefab ballprefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BallPrefab rigidball = Instantiate<BallPrefab>(ballprefab);
            rigidball.transform.localPosition = transform.position;

            rigidball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(500, 750));
        }
    }
}
