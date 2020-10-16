SCRIPTS:

WindArea.cs
-> Force Direction (0,0,90)
-> Wind Direction (0,0,90)
-> Make sure that the box collider is set to trigger

TouchSpawner.cs
+TouchSpawner.cs is placed on the preFab "IceSummonPoint" which should be a child of the "character" preFab
-> Prefab set to IceCube preFab
- Summon Point set to IceSummonPoint


Under the "character" prefab
-->open IceSummonPoint
  under the TouchSpawner script add:
--> Prefab: IceCube
--> Summon Point: IceSummonPoint


