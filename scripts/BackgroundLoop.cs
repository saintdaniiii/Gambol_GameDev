using UnityEngine;

public class SparkleLoop : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float loopSpeed = 0.5f;
    private float offSet;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offSet += (Time.deltaTime * loopSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(0, offSet));
    }
}
