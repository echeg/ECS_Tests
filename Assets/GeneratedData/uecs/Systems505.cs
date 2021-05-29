#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System505 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component124,Component301,Component392>()
.ForEach((Entity e) =>{
if (HasComponent<Component438>(e))
   {
    ecb.RemoveComponent<Component438>(e);
   }
   else
   {
    ecb.AddComponent<Component438>(e);
   }
 }).Run(); }
}

}
