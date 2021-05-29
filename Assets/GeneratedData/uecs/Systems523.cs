#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System523 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component455,Component115,Component176>()
.ForEach((Entity e) =>{
if (HasComponent<Component248>(e))
   {
    ecb.RemoveComponent<Component248>(e);
   }
   else
   {
    ecb.AddComponent<Component248>(e);
   }
 }).Run(); }
}

}
