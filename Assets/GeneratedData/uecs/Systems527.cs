#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System527 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component283,Component141>()
.ForEach((Entity e) =>{
if (HasComponent<Component107>(e))
   {
    ecb.RemoveComponent<Component107>(e);
   }
   else
   {
    ecb.AddComponent<Component107>(e);
   }
 }).Run(); }
}

}
