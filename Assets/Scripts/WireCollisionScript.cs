using UnityEngine;

public class WireCollisionScript : MonoBehaviour
{
	public float range;
	public Transform point;
	public LayerMask player;
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] playerDetection = Physics2D.OverlapCircleAll(point.position, range, player);
		
		foreach(Collider2D player in playerDetection)
		{
			Destroy(gameObject);
		}
    }
	
	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(point.position, range);
	}
	
}