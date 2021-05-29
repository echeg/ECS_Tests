#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System501 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component168,Component334>()
.ForEach((Entity e) =>{
if (HasComponent<Component380>(e))
   {
    ecb.RemoveComponent<Component380>(e);
   }
   else
   {
    ecb.AddComponent<Component380>(e);
   }
 }).Run(); }
}

}
