using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System247 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component221,Component34,Component476,Component42> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component169>())
   {
    q+=1;
    var com = entity.Get<Component169>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component115>())
   {
    q+=1;
    var com = entity.Get<Component115>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component71>())
   {
    q+=1;
    var com = entity.Get<Component71>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component327>())
   {
    q+=1;
    var com = entity.Get<Component327>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
