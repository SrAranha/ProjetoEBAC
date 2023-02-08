using System.Collections.Generic;
using UnityEngine;

public class ProjectilePool : MonoBehaviour
{
    public GameObject wall;
    public GameObject projectile;
    public PlayerHandler playerHandler;
    [Space]
    [SerializeField]private int poolAmount;
    public List<GameObject> poolOfProjectiles;
    private void Awake()
    {
        poolAmount = CalcPoolAmount();
        StartPool();
    }
    /*
     * Cálculo pra automatizar o tamanho do Pool de projéteis tendo base:
     * 1. Distância que o projétil percorre.
     * 2. Velocidade do projétil.
     * 3. Tempo de cooldown para cada projétil.
     */
    private int CalcPoolAmount()
    {
        float initialPosition = playerHandler.shootPoint.transform.position.x;
        float finalPosition = wall.transform.position.x;
        float projectileVelocity = projectile.GetComponent<Projectile>().velocity;

        float distance = initialPosition - finalPosition;
        if (distance < 0) distance *= -1;
        float timeToTravel = distance / projectileVelocity;
        float amount = timeToTravel / playerHandler.shootCooldown;
        return Mathf.RoundToInt(amount++);
    }
    private void StartPool()
    {
        poolOfProjectiles = new List<GameObject>();
        for (int i = 0; i < poolAmount; i++)
        {
            var obj = Instantiate(projectile, transform);
            obj.SetActive(false);
            poolOfProjectiles.Add(obj);
        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < poolAmount; i++)
        {
            if (!poolOfProjectiles[i].activeInHierarchy)
            {
                return poolOfProjectiles[i];
            }
        }
        return null;
    }
}
