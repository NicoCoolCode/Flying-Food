using UnityEngine;

public class DontDestroyEvenThoughUnityDoesNotLikeThisName : MonoBehaviour
{
    private static DontDestroyEvenThoughUnityDoesNotLikeThisName instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance==null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
