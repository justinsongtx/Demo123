using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentProperty : MonoBehaviour
{
    public enum CompProperty
    {
        Sync
    }

    public string GetDescriptor(CompProperty comp)
    {
        if (comp == CompProperty.Sync)
        {
            return "同步功能";
        }

        return "";
    }

    public void SetComp(CompProperty comp, bool enable)
    {
        _compDescriptor[comp] = enable;
        var compPro = this.gameObject.GetComponent<ZMRNetwork.MRNetworkCharacter>();
        if (enable)
        {
            if (compPro == null)
            {
                this.gameObject.AddComponent<ZMRNetwork.MRNetworkCharacter>();
            }
            return;
        }
        else
        {
            if (compPro != null)
            {
                GameObject.DestroyImmediate(compPro);
            }
        }
    }

    public Dictionary<CompProperty, bool> Descriptor
    {
        get
        {
            return _compDescriptor;
        }
    }

    Dictionary<CompProperty, bool> _compDescriptor = new Dictionary<CompProperty, bool>
    {
        //  {CompProperty.Sync, false}
    };

}
