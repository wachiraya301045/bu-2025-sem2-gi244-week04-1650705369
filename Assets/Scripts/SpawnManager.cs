using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Update is called once per frame
    public GameObject[] dogPrefabs;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            float x = Random.Range(-10, 10);
            int index = Random.Range(0, dogPrefabs.Length);
            if (dogPrefabs[index] != null)
            Instantiate(dogPrefabs[0]);
              new Vector3(0, 0, 20);
              Quaternion.Euler(0, 180, 0);
        }
        
    }
}
