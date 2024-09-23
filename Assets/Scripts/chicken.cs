using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class chicken : MonoBehaviour
{
    [SerializeField] private BoxCollider2D b2d;
    [SerializeField] protected RectTransform rectTransform;
    private Animator animator;

    private float walk;
    [SerializeField] private Vector2 b2dSize;
    [SerializeField] private Vector2 walkpos;

    public float mindistance;
    public float walkSpeed;

    public float walktime;
    private Vector2 vel = Vector2.zero;
    public bool iswalking;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rectTransform = GetComponent<RectTransform>();
        b2dSize = b2d.size/2;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (iswalking)
        {
            //Debug.Log(Vector2.SignedAngle(rectTransform.anchoredPosition, walkpos));
            if (Vector2.Distance(rectTransform.anchoredPosition, walkpos) <= mindistance)
        {
             Vector2 newwalkpos = new Vector2(Random.Range(-b2dSize.x, b2dSize.x), Random.Range(-b2dSize.y, b2dSize.y));
             walkpos = newwalkpos;
             walktime = 0f;
             GameManager.Instance.IncraseValie();
        }
        else
        {
                //transfrom 
                rectTransform.anchoredPosition = Vector2.SmoothDamp(rectTransform.anchoredPosition,walkpos,ref vel,walkSpeed);

                //animation

                Vector2 currentpos = rectTransform.anchoredPosition;
                Vector2 difference = currentpos - walkpos;
                Vector2 Normalizeddiff = difference.normalized;
                
   



                animator.SetFloat("WalkX", Normalizeddiff.x);
                animator.SetFloat("WalkY", Normalizeddiff.y);
        }

    }
}

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(new Vector3(walkpos.x, walkpos.y,0f), new Vector3(1f, 1f, 1f));
    }

    public void resizeCoop()
    {
        b2dSize = b2d.size / 2;
        
    }

    
}
