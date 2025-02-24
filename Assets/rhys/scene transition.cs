using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenetransition : MonoBehaviour
{
    // Start is called before the first frame update

    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;
    public GameObject fadeInPannel;
    public GameObject fadeOutPannel;
    public float fadeWait;

    private void Awake()
    {
        if(fadeInPannel != null)
        {
            GameObject panel = Instantiate(fadeInPannel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerStorage.initialValue = playerPosition;
            //SceneManager.LoadScene(sceneToLoad);
            StartCoroutine(FadeCo());
        }

    }

    public IEnumerator FadeCo()
    {
        if (fadeOutPannel != null)
        {
            Instantiate(fadeOutPannel, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(fadeWait);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
