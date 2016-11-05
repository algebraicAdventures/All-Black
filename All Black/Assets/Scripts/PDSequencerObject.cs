﻿using UnityEngine;
using System.Collections;

public class PDSequencerObject : MonoBehaviour {

    PureDataSequenceItem sequenceItem;
    Vector2 scroll;

    void OnGUI()
    {
        GUILayout.Label("Current Item: " + (sequenceItem == null ? "None" : sequenceItem.ToString()));

        GUILayout.Space(16);

        scroll = GUILayout.BeginScrollView(scroll, GUILayout.Width(Screen.width - 50));

        GUILayout.Label("Plays the sequence named 'test'. You can watch it's progress in the PureData script under Sequences.");
        if (GUILayout.Button("Play"))
        {
            sequenceItem = PureData.PlaySequence("test");
        }

        GUILayout.Space(8);

        if (sequenceItem != null)
        {
            GUILayout.Label("Stops the sequence if it is still playing.");
            if (GUILayout.Button("Stop"))
            {
                sequenceItem.Stop();
                sequenceItem = null;
            }
        }

        GUILayout.EndScrollView();
    }
}
