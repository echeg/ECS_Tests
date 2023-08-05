using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System227 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component328,Component87,Component64> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component425>())
   {
    q+=1;
    var com = entity.Get<Component425>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component469>())
   {
    q+=1;
    var com = entity.Get<Component469>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component462>())
   {
    q+=1;
    var com = entity.Get<Component462>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component402>())
   {
    q+=1;
    var com = entity.Get<Component402>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
