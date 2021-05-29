#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcsBurst{


[AlwaysUpdateSystem]class System571 : SystemWithBuffer{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
 }
  protected override void OnUpdate(){
var ecb = _addCommandBufferSystem.CreateCommandBuffer();
Entities
.WithAll<Component461,Component238>()
.ForEach((Entity e) =>{
   var e1 = ecb.CreateEntity();
   ecb.AddComponent(e1, new TicksCooldownComponent(10));
  ecb.AddComponent(e1, new Component317());
 }).Run(); }
}

}
