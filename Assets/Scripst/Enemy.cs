using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed =2f;
    [SerializeField] private float khoangcach=5f;
    private Vector3 startPos;
    private bool sangphai=true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float kctrai=startPos.x - khoangcach;
        float kcphai=startPos.x + khoangcach;
        if(sangphai){
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if(transform.position.x >= kcphai){
                sangphai= false;
                Flip();
            }
        }else{
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if(transform.position.x <= kctrai){
                sangphai= true;
                Flip();
            }
        }
        
    }
    private void Flip(){
        Vector3 scaler=transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
