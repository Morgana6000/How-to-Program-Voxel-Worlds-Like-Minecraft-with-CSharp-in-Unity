using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour {
    void Start() {
        Mesh mesh;
        MeshFilter mf = this.gameObject.AddComponent<MeshFilter>();
        MeshRenderer mr = this.gameObject.AddComponent<MeshRenderer>();

        mesh = new Mesh();
        mesh.name = "ScriptedQuad";

        Vector3[] vertices = new Vector3[4];
        Vector3[] normals = new Vector3[4];
        Vector2[] uvs = new Vector2[4];
        int[] triangles = new int[6];

        Vector2 uv00 = new Vector2(0, 0);
        Vector2 uv10 = new Vector2(1, 0);
        Vector2 uv01 = new Vector2(0, 1);
        Vector2 uv11 = new Vector2(1, 1);

        Vector3 p0 = new Vector3(-0.5f, -0.5f, 0.5f);
        Vector3 p1 = new Vector3(0.5f, -0.5f, 0.5f);
        Vector3 p2 = new Vector3(0.5f, -0.5f, -0.5f);
        Vector3 p3 = new Vector3(-0.5f, -0.5f, -0.5f);
        Vector3 p4 = new Vector3(-0.5f, 0.5f, 0.5f);
        Vector3 p5 = new Vector3(0.5f, 0.5f, 0.5f);
        Vector3 p6 = new Vector3(0.5f, 0.5f, -0.5f);
        Vector3 p7 = new Vector3(-0.5f, 0.5f, -0.5f);
    }

    void Update() {
        
    }
}
