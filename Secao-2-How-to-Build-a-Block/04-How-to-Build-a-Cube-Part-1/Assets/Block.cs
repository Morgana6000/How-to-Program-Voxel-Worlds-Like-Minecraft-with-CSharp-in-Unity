using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    [System.Serializable]
    public enum BlockSide {BOTTIM, TOP, LEFT, RIGHT, FRONT, BACK};
    public BlockSide side = BlockSide.FRONT;

    void Start() {
        MeshFilter mf = this.gameObject.AddComponent<MeshFilter>();
        MeshRenderer mr = this.gameObject.AddComponent<MeshRenderer>();

        Quad q = new Quad();
        mf.mesh = q.Build(BlockSide.FRONT);
    }

    void Update() {
        
    }
}
