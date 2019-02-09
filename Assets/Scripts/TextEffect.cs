using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// The effect shader is located at "\TextMesh Pro\Resources\Shaders\".
// TMP_SDF-Mobile-Custom.shader
public class TextEffect : MonoBehaviour {

    public TextMeshProUGUI txtPro;

    private float animationTime = 0f;

	// Use this for initialization
	void Start () {
        UpdateTextEffect(0f);
    }
	
	// Update is called once per frame
	void Update () {
        animationTime += Time.deltaTime * 0.5f;
        float val = Mathf.Abs(Mathf.Sin(animationTime) * 0.9f);
        UpdateTextEffect(val);
    }

    private void UpdateTextEffect(float val)
    {
        txtPro.materialForRendering.SetFloat("_Noise", val);
    }
}
