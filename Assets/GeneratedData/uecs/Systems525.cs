#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System525 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component404>()
.ForEach((Entity e) =>{
if (HasComponent<Component386>(e))
   {
    ecb.RemoveComponent<Component386>(e);
   }
   else
   {
    ecb.AddComponent<Component386>(e);
   }
 }).Run(); }
}

}
