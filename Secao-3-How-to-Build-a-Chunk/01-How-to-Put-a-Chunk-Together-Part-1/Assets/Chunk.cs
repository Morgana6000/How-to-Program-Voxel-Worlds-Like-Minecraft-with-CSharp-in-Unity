using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour {
    public Material atlas;

    public int widht = 2;
    public int height = 2;
    public int depth = 2;

    public Block[,,] blocks;

    void Start() {
        MeshFilter mf = this.gameObject.AddComponent<MeshFilter>();
        MeshRenderer mr = this.gameObject.AddComponent<MeshRenderer>();
        mr.material = atlas;
        blocks = new Block[widht, height, depth];

        for(int z = 0; z < depth; z++) {
            for(int y = 0; y < height; y++) {
                for(int x - 0; x < widht; x++) {
                    blocks[x, y, z] = new Block(new Vector3(x, y, z), MeshUtils.BlcokType.DIRT);
                }
            }
        }
    }

    void Update() {
        
    }
}
