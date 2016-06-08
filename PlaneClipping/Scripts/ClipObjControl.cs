using UnityEngine;
using System.Collections;

public class ClipObjControl : MonoBehaviour {

    public Transform clipObjTrans;
    public SkinnedMeshRenderer skinRenderer;

    private Material clipMaterial;

    private Vector3 clipPos;
    private Vector3 clipNormal;

    void Start() {
        if (skinRenderer == null)
            return;

        clipMaterial = skinRenderer.sharedMaterial;
    }

    void SetMaterialValue(Vector3 pos, Vector3 normal)
    {
        if (clipMaterial == null)
            return;

        clipMaterial.SetVector("_ClipObjPos", pos);
        clipMaterial.SetVector("_ClipObjNormal", normal);
    }
	
	void Update () {
	    
        if (clipObjTrans == null || clipMaterial == null)
            return;

        clipPos = clipObjTrans.position;

        clipNormal = clipObjTrans.rotation * Vector3.forward;

        SetMaterialValue(clipPos, clipNormal);
	}
}
