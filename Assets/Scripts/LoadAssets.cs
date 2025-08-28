using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;                   
    [SerializeField] private GameObject blueObj; 

    void Awake()
    {
        Application.targetFrameRate = 60;       
    }

    void Start()
    {
        if (redObj != null)
            Instantiate(redObj, new Vector3(2.2f, 0f, 0f), Quaternion.identity);

        if (blueObj != null)
            Instantiate(blueObj, new Vector3(-2.2f, 0f, 0f), Quaternion.identity);
    }
}
