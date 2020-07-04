using UnityEngine;
/// <summary>
/// 玩家角色控制
/// </summary>
public class Player : MonoBehaviour
{
    public int speed, coin, height;
    public float hp;
    public bool dead;
    public AudioClip soundJump, soundSlide, soundCollision;

    /// <summary>
    /// 角色跳躍:動畫、音效
    /// </summary>
    private void Jump()
    {
        
    }

    /// <summary>
    /// 角色滑行:動畫、音效
    /// </summary>
    private void Slide()
    {
        
    }

    /// <summary>
    /// 碰撞事件:控制碰撞器
    /// </summary>
    private void Hit()
    {

    }

    /// <summary>
    /// 吃金幣:碰撞金幣、變更介面金幣數量
    /// </summary>
    private void Coin()
    {
        
    }

    /// <summary>
    /// 翹辮子:播放停止行動
    /// </summary>
    private void Dead()
    {
        //print(Mathf.PI);
        print(Random.Range(1000f,100f));
    }

    private void Start()
    {
        Dead();
    }
}
