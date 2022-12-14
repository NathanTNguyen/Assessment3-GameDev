using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;
    private float startTime;
    private float length;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activeTween !=null && Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f) {
            float elapsedTime = Time.time - startTime;
            float percentageComplete = elapsedTime / activeTween.Duration;

            activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, percentageComplete*percentageComplete*percentageComplete);

        }
        else if (activeTween !=null && Vector3.Distance(activeTween.Target.position, activeTween.EndPos) <= 0.1f)
        {
            activeTween.Target.position = activeTween.EndPos;
            activeTween = null;
        }
    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (activeTween == null) {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
        startTime = Time.time;
    }
}
