using UnityEngine;
using UnityEngine.Video;

public class Enemy:MonoBehaviour

{
    public string name;
    public float speed;
    public float health;
    public float maxHealth;
    public Transform target;


    void Start()
    {
        health = maxHealth;
        Introduction();
}

    protected virtual void Introduction()
    {
        Debug.Log("Nome" + name + "Vida" + health + "Vida maxima" + maxHealth);
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime );
    }

    private void Update()
    {
        Move();
    }


}


