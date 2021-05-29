#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System521 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component355,Component151,Component109>()
.ForEach((Entity e) =>{
if (HasComponent<Component315>(e))
   {
    ecb.RemoveComponent<Component315>(e);
   }
   else
   {
    ecb.AddComponent<Component315>(e);
   }
 }).Run(); }
}

}
