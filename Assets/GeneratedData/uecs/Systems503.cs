#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System503 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component434>()
.ForEach((Entity e) =>{
if (HasComponent<Component365>(e))
   {
    ecb.RemoveComponent<Component365>(e);
   }
   else
   {
    ecb.AddComponent<Component365>(e);
   }
 }).Run(); }
}

}
