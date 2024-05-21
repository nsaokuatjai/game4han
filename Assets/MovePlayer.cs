using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField, Tooltip("移動スピード")]
    private float moveSpeed;
    private  Rigidbody2D rd;
    [SerializeField]
    private float maxSpeed;
    private Vector2  moveSpeedVector = new Vector2(0,0);
    private Animator moveAnime;
    // Start is called before the first frame update
    void Start()
    {
        float timer;
        rd = GetComponent<Rigidbody2D>();
        moveAnime = this.GetComponent<Animator>();
    }
    void FixedUpdate()
    {
 
         timer += Time.deltaTime;
        if (timer > 2f)
        {
            Unity.Debug.Log(moveSpeedVector * moveSpeed);
        }
        moveSpeedVector.x = Input.GetAxis("Horizontal");

        if (rd.velocity.x< maxSpeed && rd.velocity.x>-maxSpeed) rd.AddForce(moveSpeedVector*moveSpeed, ForceMode2D.Force);
        if(Input.GetAxisRaw("Horizontal")!=0)moveAnime.SetFloat("move", Input.GetAxisRaw("Horizontal"));
    }
    // Update is called once per frame
    void Update()
    {
        //rd.velocity = new Vector2(Input.GetAxis("Horizontal"),0).normalized * moveSpeed;
    }
}
