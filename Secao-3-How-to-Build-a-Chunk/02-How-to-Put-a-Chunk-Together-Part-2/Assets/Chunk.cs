using System.Collections.Generic;
using Unity.Burst;
using Unity.Mathematics;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

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

        var inputMeshes = new List<Mesh>(widht * height * depth);
        int vertexStart = 0;
        int triStart = 0;
        int meshCount = widht * height * depth;
        int m = 0 ;
        var job = new ProcessMeshDataJob();
        jobs.vertexStart = new NativeArray<int>(meshCount, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
        jobs.triStart = new NativeArray<int>(meshCount, Allocator.Temp, NativeArrayOptions.UninitializedMemory);

        for(int z = 0; z < depth; z++) {
            for(int y = 0; y < height; y++) {
                for(int x - 0; x < widht; x++) {
                    blocks[x, y, z] = new Block(new Vector3(x, y, z), MeshUtils.BlcokType.DIRT);
                    inputMeshes.Add(blocks[x, y, z].mesh);
                    var vcount = blocks[x, y, z].mesh.vertexCount;
                    var icount = (int)blocks[x, y, z].mesh.GetIndexCount(0);
                    jobs.vertexStart[m] = vertexStart;
                    jobs.triStart[m] = triStart;
                    vertexStart += vcount;
                    triStart += icount;
                    m++;
                }
            }
        }
    }

    void Update() {
        
    }
}
