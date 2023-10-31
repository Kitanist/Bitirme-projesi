using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    
    [SerializeField] private bool canMove = false; 
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;
    [SerializeField] private float movementSpeed;
    [SerializeField] private Vector2 Playerpos;
    [HideInInspector]
    public Vector2 movement;
    
    private Vector2 direction;
   
    public bool CanMove
    {
        get { return canMove; }
        set
        {
            canMove = value;
        }
    }
    #endregion
    
    void Update()
    {
        Move();
    }
    void FixedUpdate()
    {
     
        if (CanMove)
            rb.MovePosition(rb.position + movement * movementSpeed * Time.deltaTime);




    }
    
    void Move()
    {
        if (!CanMove) 
        {
            animator.SetFloat("Horizontal",0);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Speed", 0);
            return;
        }

            
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
        
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        
       
        Playerpos = gameObject.transform.position;
    }
}
