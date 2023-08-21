using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    protected static float topBound = 7.0f;
    protected static float moveSpeed = 50.0f;
    // Start is called before the first frame update

    protected void Awake()
    {
        StartCoroutine(MoveForward());
    }

    // Moves the projectile forward
    protected IEnumerator MoveForward()
    {
        while (transform.position.y < topBound)
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
            yield return null;
        }
        Destroy(gameObject);
    }
    // Deals damage to enemy ships
    protected virtual int DealDamage()
    {
        int damage = 3;
        return damage;
    }
    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        enemy.CurHealth -= DealDamage();
        Destroy(gameObject);
        if (enemy.CurHealth <= 0)
        {
            Destroy(other.gameObject);
        }
    }
}
