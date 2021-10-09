using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {
    public GameObject block;
    public int width = 1;
    public int height = 1;
    public int depth = 1;

    public IEnumerator BuildWorld() {
        for(int x = 0; x < width; x++) {        
            for(int y = 0; y < height; y++) {
                for(int z = 0; z < depth; z++) {
                    if(y >= height - 2 && Random.Range(0, 100) < 50) continue;

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
