#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System511 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component239,Component413,Component388>()
.ForEach((Entity e) =>{
if (HasComponent<Component385>(e))
   {
    ecb.RemoveComponent<Component385>(e);
   }
   else
   {
    ecb.AddComponent<Component385>(e);
   }
 }).Run(); }
}

}
