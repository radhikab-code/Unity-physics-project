using UnityEngine;

public class RottenAppleFall : MonoBehaviour
{
    public GameObject Apple;
    public float height;
    public float width;
    public float Rottenapplefalltime;

    private float spawntime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawntime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= spawntime)
        {
            Debug.Log("spawn rotten apple");
            Instantiate(Apple, calculatePos(), Quaternion.identity);
            spawntime = Time.time + Rottenapplefalltime;
        }
    }

    Vector3 calculatePos()
    {
        Vector3 position = new Vector3(
            Random.Range(-30, 30),
            height,
            Random.Range(-30, 30)
        );

        return position;
    }
}
