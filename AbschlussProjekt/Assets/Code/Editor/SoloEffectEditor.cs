﻿using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SoloEffect))]
[CanEditMultipleObjects]
public class SoloEffectEditor : BaseEffectEditor
{
	#region Properties
	private SerializedProperty looping;
	private SerializedProperty lingeringDuration;
	private SerializedProperty framerateOverride;
	#endregion

	void OnEnable()
	{
		base.SetupProperties();
		lingeringDuration = serializedObject.FindProperty("lingeringDuration");
		framerateOverride = serializedObject.FindProperty("framerateOverride");
	}

	public override void OnInspectorGUI()
	{
		OnInspectorGUIStart();

		HandleEffectProperties();

		OnInspectorGUIEnd();
	}

	protected override void HandleEffectProperties()
	{
		EditorGUILayout.Space();
		EditorGUILayout.LabelField("Solo Effect Specific", EditorStyles.boldLabel);
		EditorGUILayout.PropertyField(lingeringDuration);
		EditorGUILayout.PropertyField(framerateOverride);

		base.HandleEffectProperties();
	}
}
