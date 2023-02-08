using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float velocity;
    public string tagWalls;
    public string tagEnemies;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime * Vector3.right);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag(tagWalls))
        {
            OnHit();
        }
        else if (collision.transform.CompareTag(tagEnemies))
        {
            collision.gameObject.GetComponent<Enemy>().TakeDamage(1);
            OnHit();
        }
    }
    private void OnHit()
    {
        gameObject.SetActive(false);
    }
}
