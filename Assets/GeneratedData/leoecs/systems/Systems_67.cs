using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System67 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component3> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component159>())
   {
    q+=1;
    var com = entity.Get<Component159>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component109>())
   {
    q+=1;
    var com = entity.Get<Component109>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component147>())
   {
    q+=1;
    var com = entity.Get<Component147>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component387>())
   {
    q+=1;
    var com = entity.Get<Component387>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
