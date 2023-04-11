using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZMRAvatar;

public class ConcertLoader : MonoBehaviour
{
    public GameObject role;
    // Start is called before the first frame update
    private void Start()
    {
        if (role != null) return;
        var avatarComp = this.gameObject.GetComponentInChildren<MRAvatarComponent>();
        if (avatarComp) role = avatarComp.gameObject;
    }

    /// <summary>
    /// 设置人模的位置
    /// </summary>
    public void SetRoleTransition(Vector3 position)
    {
        if (role == null) return;
        role.transform.position = new Vector3(position.x, position.y, position.z);
    }

    /// <summary>
    /// 设置人模的位置和方向
    /// </summary>
    public void SetRoleTransition(Vector3 position, Vector3 eulerAngles)
    {
        if (role == null) return;
        role.transform.position = new Vector3(position.x, position.y, position.z);
        role.transform.eulerAngles = new Vector3(eulerAngles.x, eulerAngles.y, eulerAngles.z);
    }
    
    /// <summary>
    /// 设置人模的位置和方向
    /// </summary>
    public void SetRoleTransition(float posX, float posY, float posZ, float eulerX, float eulerY, float eulerZ)
    {
        if (role == null) return;
        role.transform.position = new Vector3(posX, posY, posZ);
        role.transform.eulerAngles = new Vector3(eulerX, eulerY, eulerZ);
    }
}
