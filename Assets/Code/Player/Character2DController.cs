using UnityEngine;

public class Character2DController : MonoBehaviour

{
    [SerializeField]
    private Transform TriggerElevator;
    public Animator animator;

    public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D _rigidbody;
    //private Animator anim;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    //    anim = GetComponent<Animator>();
    }

    private void Update()
    {
      var movement = Input.GetAxis("Horizontal");
      transform.position += new Vector3(movement,-0,0) * Time.deltaTime * MovementSpeed;
      
      //if(moveInput == 0)
      //{
      //  anim.SetBool("isRunning",false);
      //}
      //else
      //{
      //  anim.SetBool("isRunning",true);
      //}
      
      if (!Mathf.Approximately(0,movement))
          transform.rotation = movement > 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity; 
      
      if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)< 0.001f)
      {
        _rigidbody.AddForce(new Vector2(0,JumpForce),ForceMode2D.Impulse);
      }
      
    }

}
