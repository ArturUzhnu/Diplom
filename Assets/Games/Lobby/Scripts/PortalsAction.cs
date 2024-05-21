using UnityEngine;

public class PortalsAction : MonoBehaviour
{
    [SerializeField] private GameObject portalBlockParty;
    [SerializeField] private GameObject portalDoll;
    [SerializeField] private GameObject portalUltimateKnockout;

    void Start()
    {

        Rigidbody rigidbodyBlockParty = portalBlockParty.AddComponent<Rigidbody>();
        rigidbodyBlockParty.useGravity = false;
        rigidbodyBlockParty.isKinematic = true;

        BoxCollider colliderBlockParty = portalBlockParty.AddComponent<BoxCollider>();
        BoxCollider colliderDoll = portalDoll.AddComponent<BoxCollider>();
        BoxCollider colliderUltimateKnockout = portalUltimateKnockout.AddComponent<BoxCollider>();


        colliderBlockParty.isTrigger = true;
        colliderDoll.isTrigger = true;
        colliderUltimateKnockout.isTrigger = true;


        //TriggerAction triggerForBlockParty = new TriggerAction("BlockParty");
        TriggerAction triggerForBlockParty = portalBlockParty.AddComponent<TriggerAction>();
        triggerForBlockParty.NameGame = "BlockParty";
        triggerForBlockParty.Multiplayer = true;

        TriggerAction triggerForDoll = portalDoll.AddComponent<TriggerAction>();
        triggerForDoll.NameGame = "Doll";
        triggerForDoll.Multiplayer = true;


        TriggerAction triggerForUltimateKnockout = portalUltimateKnockout.AddComponent<TriggerAction>();
        triggerForUltimateKnockout.NameGame = "UltimateKnockout";
        triggerForUltimateKnockout.Multiplayer = true;

    }

}
