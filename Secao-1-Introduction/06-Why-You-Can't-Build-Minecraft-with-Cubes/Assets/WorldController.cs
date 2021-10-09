using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {
    public GameObject block;
    public int worldSize = 2;

    public IEnumerator BuildWorld() {
        for(int x = 0; x < worldSize; x++) {        
            for(int y = 0; y < worldSize; y++) {
                for(int z = 0; z < worldSize; z++) {
                    Vector3 pos = new Vector3(x, y, z);
                    GameObject cube = GameObject.Instantiate(block, pos, Quaternion.identity);
                    cube.name = x + "-" + y + "-" + z;
                    cube.GetComponent<Renderer>().material = new Material (Shader.Find("Standard"));
                }

                yield return null;
            }
        }
    }

    void Start() {
        StartCoroutine(BuildWorld());
    }

    void Update() {
        
    }
}
