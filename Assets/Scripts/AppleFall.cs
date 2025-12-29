using UnityEngine;

public class AppleFall : MonoBehaviour
{
    public GameObject Apple;
    public float height;
    public float width;
    public float applefalltime;

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
            Debug.Log("spawn");
            Instantiate(Apple, calculatePosition(), Quaternion.identity);
            spawntime = spawntime + applefalltime;
        }
    }

    Vector3 calculatePosition()
    {
     Vector3 position = new Vector3(Random.Range(-30,30), height, Random.Range(-30,30));
     return position;      
    } 
}
