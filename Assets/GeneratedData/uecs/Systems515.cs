#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System515 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component230,Component180,Component128>()
.ForEach((Entity e) =>{
if (HasComponent<Component415>(e))
   {
    ecb.RemoveComponent<Component415>(e);
   }
   else
   {
    ecb.AddComponent<Component415>(e);
   }
 }).Run(); }
}

}
