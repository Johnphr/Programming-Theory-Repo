using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ENCAPSULATION
    public int MaxHealth { get; private set; }
    public int CurHealth { get; set; }
    private float bottomBound = -3f;

    // Start is called before the first frame update
    private void Awake()
    {
        MaxHealth = 3;
        CurHealth = MaxHealth;
        StartCoroutine(MoveDown());
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator MoveDown()
    {
        while (transform.position.y > bottomBound)
        {
            transform.Translate(Vector2.down * Time.deltaTime);
            yield return null;
        }
        SceneController.ReturnToMenu();
    }
}
