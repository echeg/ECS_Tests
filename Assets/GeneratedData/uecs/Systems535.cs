#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System535 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component132,Component488>()
.ForEach((Entity e) =>{
if (HasComponent<Component246>(e))
   {
    ecb.RemoveComponent<Component246>(e);
   }
   else
   {
    ecb.AddComponent<Component246>(e);
   }
 }).Run(); }
}

}
