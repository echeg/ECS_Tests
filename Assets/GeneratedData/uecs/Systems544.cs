#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System544 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component142,Component267>()
.ForEach((Entity e) =>{
if (HasComponent<Component319>(e))
   {
    ecb.RemoveComponent<Component319>(e);
   }
   else
   {
    ecb.AddComponent<Component319>(e);
   }
 }).Run(); }
}

}
