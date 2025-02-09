using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float enemySpeed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * enemySpeed );
    }
}
