#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System519 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component24>()
.ForEach((Entity e) =>{
if (HasComponent<Component387>(e))
   {
    ecb.RemoveComponent<Component387>(e);
   }
   else
   {
    ecb.AddComponent<Component387>(e);
   }
 }).Run(); }
}

}
