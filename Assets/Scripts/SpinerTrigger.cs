using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinerTrigger : MonoBehaviour
{
    public Transform spiner;
    public GameObject marker;
    public float speed = 0f;
    public float speedMax = 2000f;
    public float slowDown = 10f;
    public string stopAt = "cbmmls";
    public bool stop = false;
    public bool spinning = false;

    public void StartSpin()
    {
        this.speed = this.speedMax;
        this.spinning = true;
        this.stop = false;
    }

    private void FixedUpdate()
    {
        this.Spinning();
    }

    private void Spinning()
    {
        this.spiner.Rotate(0, 0, - (Time.deltaTime * this.speed));
        this.Stoping();
    }

    //private void Stoping()
    //{
    //    if (!this.stop) return;
    //    if(this.stopAt == SpinnerMarker.instance.giftName)
    //    {
    //        this.spinning = false;
    //    }
    //    if (this.spinning) return;
        
    //    if(this.speed >= 200)
    //        this.speed -= this.slowDown;

    //    else if (this.stopAt == SpinnerMarker.instance.giftName)
    //    {
    //        this.speed = 0;
    //    }
    //}

    private void Stoping()
    {
        if (!this.stop) return;

        // Kiểm tra điều kiện dừng khi vòng quay dừng đúng tại giftName
        if (this.spinning)
        {
            // Giảm tốc độ dần dần để dừng lại chính xác
            if (this.speed >= 300)
            {
                this.speed -= this.slowDown;
            }
            else if (this.stopAt == SpinnerMarker.instance.giftName)
            {
                // Dừng vòng quay khi tốc độ đủ chậm và khớp với giftName
                this.speed = 0;
                this.spinning = false;
            }
        }
    }
}
