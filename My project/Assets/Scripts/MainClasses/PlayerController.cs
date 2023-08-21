using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ABSTRACTION

    private static GameObject theCube;
    private static float moveSpeed = 10f;
    private static Quaternion leftDeviation; 
    private static Quaternion rightDeviation;

    // Start is called before the first frame update
    void Start()
    {
        theCube = gameObject;
        leftDeviation = Quaternion.Euler(0, 0, 10);
        rightDeviation = Quaternion.Euler(0, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Instantiates a Projectile
    public static void Shoot(GameObject projectilePrefab, bool burst)
    {
        if (!burst)
        {
            Instantiate(projectilePrefab, theCube.transform.position, projectilePrefab.transform.rotation);
        }
        else if (burst)
        {
            Instantiate(projectilePrefab, theCube.transform.position, projectilePrefab.transform.rotation * leftDeviation);
            Instantiate(projectilePrefab, theCube.transform.position, projectilePrefab.transform.rotation * rightDeviation);
        }
    }
    public static void MovePlayer(float input)
    {
        theCube.transform.Translate(Vector2.right * input * Time.deltaTime * moveSpeed);
    }
}
