using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    [Header("Basics")]
    public int speed;
    [Header("Inputs")]
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public KeyCode shoot = KeyCode.Space;
    [Header("Shooting")]
    public float shootCooldown;
    public GameObject shootPoint;
    public ProjectilePool projectilePool;
    private float cooldown;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        if (Input.GetKey(shoot))
        {
            if (cooldown <= 0)
            {
                Shoot();
            }
        }
        cooldown -= Time.deltaTime;
    }
    private void MovePlayer()
    {
        if (Input.GetKey(moveUp))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up);
        }
        if (Input.GetKey(moveDown))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.down);
        }
    }
    private void Shoot()
    {
        cooldown = shootCooldown;
        var projectile = projectilePool.GetPooledObject();
        projectile.SetActive(true);
        projectile.transform.position = shootPoint.transform.position;
    }
}
