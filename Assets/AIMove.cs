using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{


    public float moveSpeed = 3f;
    public float rotSpeed = 100f;

    public bool is_wondering = false;
    private bool is_rotating_left = false;
    private bool is_rotating_right = false;
    private bool is_walking = false;


    public enum characterstate
    {
        IDLE,
        MOVING,
        DIGGING,

    };


    // Start is called before the first frame update
    void Start()
    {
        // characterstate ai_state;
        // ai_state = characterstate.IDLE;


    }

    // Update is called once per frame
    void Update()
    {


        if (is_wondering == false)
        {
            StartCoroutine(Wander());
        }

        if (is_rotating_right == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * moveSpeed);
        }

        if (is_rotating_left == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -moveSpeed);
        }

        if (is_walking)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }



    }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 3);
        int rotatewait = Random.Range(3, 10);
        int rotateLoR = Random.Range(1, 2);
        int walkWait = Random.Range(1, 2);
        int walkTime = Random.Range(1, 3);

        is_wondering = true;
        yield return new WaitForSeconds(walkWait);
        is_walking = true;
        yield return new WaitForSeconds(walkTime);
        is_walking = false;
        yield return new WaitForSeconds(rotatewait);
        if (rotateLoR == 1)
        {
            is_rotating_right = true;
            yield return new WaitForSeconds(rotTime);
            is_rotating_right = false;

        }

        if (rotateLoR == 2)
        {
            is_rotating_left = true;
            yield return new WaitForSeconds(rotTime);
            is_rotating_left = false;

        }
        is_wondering = false;

    }
}