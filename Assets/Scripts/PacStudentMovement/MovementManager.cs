using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    [SerializeField] GameObject item;
    private Tweener tweener;
    public AudioSource PacMoving;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GameObject.Find("TweenController").GetComponent<Tweener>();
        StartCoroutine(playPacStudentMovement());
        PacMoving.loop = true;
        PacMoving.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator playPacStudentMovement()
    {
        while(true)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-0.75f, 3.24f, 0.0f), 1.5f);
            yield return new WaitForSeconds(1.5f);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-0.64f, -1.97f, 0.0f), 1.5f);
            yield return new WaitForSeconds(1.5f);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-7.02f, -1.97f, 0.0f), 1.5f);
            yield return new WaitForSeconds(1.5f);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-7.02f, 3.16f, 0.0f), 1.5f);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
