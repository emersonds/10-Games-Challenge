using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField, Tooltip("Moving Obstacle prefab")]
    private GameObject obstacle;

    // current existing obstacle
    private GameObject currObstacle;

    // Starting x pos for obstacle that is off screen
    private float obstacleX = 2f;

    // Random y pos for obstacle
    private float obstacleYMin = -0.3f;
    private float obstacleYMax = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Spawn the first obstacle
        currObstacle = Instantiate(obstacle, new Vector3(obstacleX, Random.Range(obstacleYMin, obstacleYMax)), Quaternion.identity);
    }


    // Called when a collision occurs on the edge collider
    private void OnCollisionEnter2D(Collision2D coll)
    {
        // Destroy colliding obstacle
        Destroy(currObstacle);

        // Instantiate new obstacle
        currObstacle = Instantiate(obstacle, new Vector3(obstacleX, Random.Range(obstacleYMin, obstacleYMax)), Quaternion.identity);
    }
}
