using UnityEngine;
using System.Collections;

public class PDSequencerObject : MonoBehaviour {

    PureDataSequenceItem sequenceItem1, sequenceItem2, sequenceItem3;
    Vector2 scroll;

    void Start()
    {
        sequenceItem1 = PureData.PlaySequence("1");
        sequenceItem2 = PureData.PlaySequence("2");
        sequenceItem3 = PureData.PlaySequence("3");
    }
}
