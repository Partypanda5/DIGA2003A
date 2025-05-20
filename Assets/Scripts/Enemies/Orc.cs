using UnityEngine;

public class Orc : Enemy
{
    public LayerMask groundLayer;  // Set this in the Inspector
    void Update()
    {
        Move();

        Debug.DrawRay(gameObject.transform.position, Vector2.down * 2, Color.red); // we can use this to debug the raycast in the scene

        RaycastHit2D groundInfo = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 2f, groundLayer); //add layermask here

        //Only hits colliders on the groundLayer
        if (groundInfo.collider == false)
        {
            transform.Rotate(0f, 180f, 0f);
        }
    }

    void Move()
    {
        transform.Translate(Vector2.right * 2.0f * Time.deltaTime);
    }

    public void Roar() 
    {
        Debug.Log("Orc Roars");
    }
}
