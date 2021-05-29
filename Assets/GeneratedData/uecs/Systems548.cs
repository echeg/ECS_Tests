#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System548 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component486>()
.ForEach((Entity e) =>{
if (HasComponent<Component294>(e))
   {
    ecb.RemoveComponent<Component294>(e);
   }
   else
   {
    ecb.AddComponent<Component294>(e);
   }
 }).Run(); }
}

}
