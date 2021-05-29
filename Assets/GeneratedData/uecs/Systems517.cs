#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System517 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component456,Component407>()
.ForEach((Entity e) =>{
if (HasComponent<Component356>(e))
   {
    ecb.RemoveComponent<Component356>(e);
   }
   else
   {
    ecb.AddComponent<Component356>(e);
   }
 }).Run(); }
}

}
