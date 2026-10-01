using UnityEngine;
using Yarn.Unity;
using System.Collections;
using System.Timers;

public class orb : MonoBehaviour
{
    [YarnCommand("grow")]
    public IEnumerator Grow(float target, float time)
    {
        float elapsed = 0f;
        Vector3 targetScale = target * Vector3.one;
        yield return new WaitForSeconds(time);
        transform.localScale = targetScale;

       
        while (elapsed < time)
        {
            float elapsedPct = elapsed / time;
            Vector3 currScale = Mathf.Lerp(1f, target, elapsedPct) * Vector3.one;
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localScale = elapsed * targetScale;
    }

    [YarnCommand("change_light")]
    public void ChangeLight(GameObject target)
    {
        target.transform.position = transform.position + Random.onUnitSphere * 2f;
    }
}
